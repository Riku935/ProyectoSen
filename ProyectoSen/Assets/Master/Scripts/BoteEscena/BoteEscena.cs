using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoteEscena : MonoBehaviour
{
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BoteEscenaEvent += turnBote;
    }
    private void BoteStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            SceneManager.LoadScene(1);
            isTurnOn = true;
        }
    }
    private void turnBote(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            BoteStage();
        }
    }
    private void OnDisable()
    {
        EventManager.BoteEscenaEvent -= turnBote;
    }
}
