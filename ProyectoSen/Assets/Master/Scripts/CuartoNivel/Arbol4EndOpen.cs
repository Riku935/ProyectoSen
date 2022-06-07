using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol4EndOpen : MonoBehaviour
{
    public GameObject dialogo;
    public GameObject trigger;
    public static int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.Arbol4EndEvent += turnArbolEnd4;
    }
    private void Update()
    {

    }
    private void Arbol4EndStage()
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
    private void turnArbolEnd4(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            Arbol4EndStage();
        }
    }
    private void OnDisable()
    {
        EventManager.ArbolEvent -= turnArbolEnd4;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel2_Decaido");
    }
}
