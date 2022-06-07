using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensajeInicio : MonoBehaviour
{
    public GameObject mensajeDeInicio;
    void Start()
    {
        mensajeDeInicio.SetActive(true);
        StartCoroutine(wastingTime(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        mensajeDeInicio.SetActive(false);
    }
}
