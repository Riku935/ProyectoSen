using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoteEscena2 : MonoBehaviour
{
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BoteEscena2Event += turnBote2;
    }
    private void BoteStage2()
    {
        if (isActivated == true && !isTurnOn)
        {
            SceneManager.LoadScene(2);
            isTurnOn = true;
        }
    }
    private void turnBote2(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            BoteStage2();
        }
    }
    private void OnDisable()
    {
        EventManager.BoteEscena2Event -= turnBote2;
    }
}
