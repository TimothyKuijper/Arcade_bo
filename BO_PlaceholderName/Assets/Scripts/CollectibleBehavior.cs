using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEditor.UIElements;
using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    public ParticleSystem _particleSystem;
    public float degreesPerSecond = 20;

    void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            _particleSystem.Play();
            gameObject.SetActive(false);
        }
    }
}
