using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    Vector3 spawnPosition;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawnPosition = new Vector3(transform.position.x, transform.position.y);
            Instantiate(objectToSpawn, spawnPosition, transform.rotation);
        }

    }
}
