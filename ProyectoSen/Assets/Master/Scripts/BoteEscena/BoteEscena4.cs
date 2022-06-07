using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoteEscena4 : MonoBehaviour
{
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BoteEscena4Event += turnBote4;
    }
    private void BoteStage4()
    {
        if (isActivated == true && !isTurnOn)
        {
            SceneManager.LoadScene(5);
            isTurnOn = true;
        }
    }
    private void turnBote4(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            BoteStage4();
        }
    }
    private void OnDisable()
    {
        EventManager.BoteEscena4Event -= turnBote4;
    }
}
