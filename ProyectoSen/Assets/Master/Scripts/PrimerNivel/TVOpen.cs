using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVOpen : MonoBehaviour
{
    public GameObject TVEndText;
    public GameObject TvLight;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.TVEvent += turnTV;
    }
    private void TVStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            TVEndText.SetActive(true);
            TvLight.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnTV(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            TVStage();
        }
    }
    private void OnDisable()
    {
        EventManager.TVEvent -= turnTV;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        TVEndText.SetActive(false);
    }
}
