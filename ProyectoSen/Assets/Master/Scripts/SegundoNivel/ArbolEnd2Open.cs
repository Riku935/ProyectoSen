using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArbolEnd2Open : MonoBehaviour
{
    public GameObject dialogo;
    public static int objectId2;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.ArbolEnd2Event += turnArbolEnd2;
    }
    private void Update()
    {

    }
    private void ArbolEndStage2()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(5f));
            dialogo.SetActive(true);
            StartCoroutine(wastingTime(20));
            isTurnOn = true;
        }
    }
    private void turnArbolEnd2(int TriggerID)
    {
        if (TriggerID == objectId2)
        {
            isActivated = true;
            ArbolEndStage2();
        }
    }
    private void OnDisable()
    {
        EventManager.ArbolEnd2Event -= turnArbolEnd2;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel3_Deprimido");
    }
}
