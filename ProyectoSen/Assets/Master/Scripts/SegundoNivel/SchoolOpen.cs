using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolOpen : MonoBehaviour
{
    public GameObject SchoolEndText;
    public GameObject calificacion;
    public GameObject schoolLight;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.SchoolEvent += turnSchool;
    }
    private void Update()
    {

    }
    private void SchoolStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            SchoolEndText.SetActive(true);
            calificacion.SetActive(true);
            schoolLight.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnSchool(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            SchoolStage();
        }
    }
    private void OnDisable()
    {
        EventManager.SchoolEvent -= turnSchool;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        SchoolEndText.SetActive(false);
    }
}
