using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArbolOpen : MonoBehaviour
{
    public GameObject dialogo;
    public GameObject barrera;
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.ArbolEvent += turnArbol;
    }
    private void Update()
    {

    }
    private void ArbolStage1()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(5f));
            dialogo.SetActive(true);
            isTurnOn = true;
            barrera.SetActive(false);
        }
    }

    private void turnArbol(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            ArbolStage1();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ArbolEndOpen.objectId = 8;
        objectId1 = 20;
    }
    private void OnDisable()
    {
        EventManager.ArbolEvent -= turnArbol;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel2_Decaido");
    }
}
