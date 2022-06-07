using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color newColor;

    private void Start()
    {
        EventManager.ExampleEvent += SetNewColor;
    }

    private void SetNewColor()
    {
        GetComponent<Renderer>().material.color = newColor;
    }
    private void OnDisable()
    {
        EventManager.ExampleEvent -= SetNewColor;
    }
}
