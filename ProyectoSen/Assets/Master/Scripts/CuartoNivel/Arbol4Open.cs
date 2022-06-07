using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol4Open : MonoBehaviour
{
    public GameObject dialogo;
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.Arbol4Event += turnArbol4;
    }
    private void Update()
    {

    }
    private void ArbolStage4()
    {
        if (isActivated == true && !isTurnOn)
        {
            //StartCoroutine(wastingTime(5f));
            dialogo.SetActive(true);
            isTurnOn = true;
        }
    }

    private void turnArbol4(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            ArbolStage4();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Arbol4EndOpen.objectId = 1;
        objectId1 = 20;
    }
    private void OnDisable()
    {
        EventManager.Arbol4Event -= turnArbol4;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel2_Decaido");
    }
}
