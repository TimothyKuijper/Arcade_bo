using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenRoomcheck : MonoBehaviour
{
    public GameObject HiddenRoom;
    public float alpha = 0.5f;
    public float alphaexit = 1f;

    void Start()
    {
        HiddenRoom = GameObject.FindGameObjectWithTag("hidden");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ChangeAlpha(HiddenRoom.GetComponent<Renderer>().material, alpha);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldcolor = mat.color;
        Color newcolor = new Color(oldcolor.r, oldcolor.g, oldcolor.b, alphaVal);
        GetComponent<Renderer>().material.color = newcolor;
    }


}
