using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol5Open : MonoBehaviour
{
    public GameObject dialogo;
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.Arbol5Event += turnArbol5;
    }
    private void Update()
    {

    }
    private void ArbolStage5()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(5f));
            dialogo.SetActive(true);
            isTurnOn = true;
        }
    }

    private void turnArbol5(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            ArbolStage5();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Arbol5EndOpen.objectId = 25;
        objectId1 = 20;
    }
    private void OnDisable()
    {
        EventManager.Arbol5Event -= turnArbol5;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel2_Decaido");
    }
}
