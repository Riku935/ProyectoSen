using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arbol3Open : MonoBehaviour
{
    public GameObject dialogo;
    public GameObject barrera;
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.Arbol3Event += turnArbol3;
    }
    private void Update()
    {

    }
    private void ArbolStage3()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(20f));
            dialogo.SetActive(true);
            barrera.SetActive(false);
            isTurnOn = true;
        }
    }

    private void turnArbol3(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            ArbolStage3();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //ArbolEndOpen.objectId = 8;
        //objectId1 = 20;
    }
    private void OnDisable()
    {
        EventManager.Arbol3Event -= turnArbol3;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Nivel4_Esperanza");
    }
}
