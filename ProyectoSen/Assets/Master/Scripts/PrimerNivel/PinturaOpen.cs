using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinturaOpen : MonoBehaviour
{
    public GameObject PinturaEndText;
    public Color PinturaColor;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.PinturaEvent += turnPintura;
    }
    private void PinturaStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            GetComponent<Renderer>().material.color = PinturaColor;
            PinturaEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnPintura(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            PinturaStage();
        }
    }
    private void OnDisable()
    {
        EventManager.PinturaEvent -= turnPintura;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        PinturaEndText.SetActive(false);
    }
}
