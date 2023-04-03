using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class BulletBehavior : MonoBehaviour
{
    Rigidbody2D Rigidbody;
    bool isFired;
    private Vector3 shotMultiplier;
    public Vector3 ScreenPos;
    public Vector3 WorldPos;

    void Start()
    {
       Rigidbody = GetComponent<Rigidbody2D>();
        isFired = false;
        Destroy(gameObject, 1.5f);
        shotMultiplier = new Vector3(10, 10);
    }

    void Update()
    {

        Vector3 ScreenPos = Input.mousePosition;
        ScreenPos.z = 0 - Camera.main.transform.position.z;


        Vector3 WorldPos = Camera.main.ScreenToWorldPoint(ScreenPos);

        ScreenPos = Input.mousePosition;
        ScreenPos.z = Camera.main.nearClipPlane + 1;

        Vector3 Shot = (WorldPos + shotMultiplier) - transform.position;

        if (isFired == false)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                Rigidbody.AddForce(Shot,ForceMode2D.Impulse);
                isFired = true;
            }
        }

    }

}
