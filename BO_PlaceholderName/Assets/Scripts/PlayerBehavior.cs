using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb2d;
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
        maxSpeed = 30f;
        movespeed = 100f;
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
            Debug.Log("HOR");
            rb2d.AddForce(new Vector3(moveHorizontal * movespeed, 0), ForceMode2D.Impulse);
        }

        if (!isjumping && moveVertical > 0.1f)
        {
            Debug.Log("JMP");
            rb2d.AddForce(new Vector3(0f, moveVertical * jumpforce), ForceMode2D.Impulse);
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

