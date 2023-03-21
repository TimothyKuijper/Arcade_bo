using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathRetry : MonoBehaviour
{
    public float retry;
    void Update()
    {
        retry = Input.GetAxisRaw("Jump");

        if (retry > 0.1f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
