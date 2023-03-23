using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    void Awake()
    {

    }

    void Update()
    {
        if (!Object1.activeInHierarchy && !Object2.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }

}
