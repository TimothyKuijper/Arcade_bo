using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private ScoreManager scoreManager;

    float movespeed;
    float jumpforce;
    bool isjumping;
    float moveHorizontal;
    float maxSpeed;
    float moveVertical;

    void Start()
    {
        scoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        maxSpeed = 30f;
        movespeed = 0.6f;
        jumpforce = 10f;
        isjumping = false;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Jump");
    }

    void FixedUpdate()
    {
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {

            rb2d.AddForce(new Vector2(moveHorizontal * movespeed, 0f), ForceMode2D.Impulse);
        }

        if (!isjumping && moveVertical > 0.1f)
        {
            rb2d.AddForce(new Vector2(0f, moveVertical * jumpforce), ForceMode2D.Impulse);
        }

        if (rb2d.velocity.magnitude > maxSpeed)
        {
            rb2d.velocity = Vector2.ClampMagnitude(rb2d.velocity, maxSpeed);
        }
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            bool v = false;
            isjumping = v;
        }

        if (collision.gameObject.CompareTag("PickUps"))
        {
            scoreManager.score++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            isjumping = true;
        }
    }



}

