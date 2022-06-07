using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol2Open : MonoBehaviour
{
    public GameObject dialogo;
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.Arbol2Event += turnArbol2;
    }
    private void Update()
    {

    }
    private void ArbolStage2()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(5f));
            dialogo.SetActive(true);
            isTurnOn = true;
        }
    }

    private void turnArbol2(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            ArbolStage2();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ArbolEnd2Open.objectId2 = 9;
        objectId1 = 21;
    }
    private void OnDisable()
    {
        EventManager.Arbol2Event -= turnArbol2;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
