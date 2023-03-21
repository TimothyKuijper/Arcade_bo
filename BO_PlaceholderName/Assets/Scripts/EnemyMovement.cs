using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float xmin;
    public float xmax;
    public int Direction;
    float Speed;


    void Start()
    {
        Speed = 0.05f;
    }

    
    void Update()
    {
        switch (Direction)
        {
            case 1:
                if ( transform.position.x > xmin)
                {
                    transform.Translate(Vector2.left * Speed);
                }
                else
                {
                    Direction = -1;
                }
                break;

            case -1:
                if ( transform.position.x < xmax)
                {
                    transform.Translate(Vector2.right * Speed);
                }
                else
                {
                    Direction = 1;
                }
                break;
        }
    }
}
