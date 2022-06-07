using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArbolEndOpen : MonoBehaviour
{
    public GameObject dialogo;
    public GameObject trigger;
    public static int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.ArbolEndEvent += turnArbolEnd;
    }
    private void Update()
    {

    }
    private void ArbolEndStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(5f));
            dialogo.SetActive(true);
            StartCoroutine(wastingTime(12));
            isTurnOn = true;
            trigger.SetActive(true);
        }
    }
    private void turnArbolEnd(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            ArbolEndStage();
        }
    }
    private void OnDisable()
    {
        EventManager.ArbolEvent -= turnArbolEnd;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel2_Decaido");
    }
}
