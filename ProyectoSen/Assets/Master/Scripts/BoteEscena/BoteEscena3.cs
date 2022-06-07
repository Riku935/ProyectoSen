using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoteEscena3 : MonoBehaviour
{
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BoteEscena3Event += turnBote3;
    }
    private void BoteStage3()
    {
        if (isActivated == true && !isTurnOn)
        {
            SceneManager.LoadScene(4);
            isTurnOn = true;
        }
    }
    private void turnBote3(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            BoteStage3();
        }
    }
    private void OnDisable()
    {
        EventManager.BoteEscena3Event -= turnBote3;
    }
}
