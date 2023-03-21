using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    float alpha = 0f;
    public GameObject Door;
    Rigidbody2D Rigidbody;
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!Object1.activeInHierarchy && !Object2.activeInHierarchy)
        {
            ChangeAlpha(Door.GetComponent<Renderer>().material, alpha);
            gameObject.SetActive(false);
        }
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldcolor = mat.color;
        Color newcolor = new Color(oldcolor.r, oldcolor.g, oldcolor.b, alphaVal);
        GetComponent<Renderer>().material.color = newcolor;
    }
}
