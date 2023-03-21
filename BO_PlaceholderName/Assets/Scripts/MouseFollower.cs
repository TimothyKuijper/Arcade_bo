using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    void Update()
    {
        Vector3 ScreenPos = Input.mousePosition;
        ScreenPos.z = 0- Camera.main.transform.position.z;

        Vector3 WorldPos = Camera.main.ScreenToWorldPoint(ScreenPos);

        transform.position = WorldPos;
    }
}
