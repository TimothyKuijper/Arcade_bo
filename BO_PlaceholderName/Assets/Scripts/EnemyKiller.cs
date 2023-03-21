using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKiller : MonoBehaviour
{
    public int Health;

    private void Start()
    {
        Health = 3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Health--;
        }
    }

    private void Update()
    {
        if (Health == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
