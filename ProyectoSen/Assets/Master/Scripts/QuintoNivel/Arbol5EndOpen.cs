using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol5EndOpen : MonoBehaviour
{
    public GameObject dialogo;
    public GameObject trigger;
    public static int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.Arbol5EndEvent += turnArbolEnd5;
    }
    private void Update()
    {

    }
    private void Arbol5EndStage()
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
    private void turnArbolEnd5(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            Arbol5EndStage();
        }
    }
    private void OnDisable()
    {
        EventManager.Arbol5EndEvent -= turnArbolEnd5;
    }

    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        //SceneManager.LoadScene("Nivel2_Decaido");
    }
}
