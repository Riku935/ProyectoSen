using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLookAt : MonoBehaviour
{
    Camera cam;
    void OnEnable()
    {
        cam = Camera.main;
    }
    void Update()
    {
        if (cam != null)
        {
            transform.LookAt(cam.transform.position, Vector3.up);
        }
    }
}
