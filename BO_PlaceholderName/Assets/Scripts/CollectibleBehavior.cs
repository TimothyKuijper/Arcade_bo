using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    ParticleSystem _particleSystem;
    public GameObject _gameObject;
    void Start()
    {
        _particleSystem = _gameObject.GetComponent<ParticleSystem>();
    }

    void Update()
    {
        
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
