using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco2Open : MonoBehaviour
{
    public GameObject BoteEndText;
    public Animator Anim;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BarcoEvent += turnBarco;
    }
    private void Update()
    {

    }
    private void BarcoStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            Anim.Play("Barco");
            BoteEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnBarco(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            BarcoStage();
        }
    }
    private void OnDisable()
    {
        EventManager.BarcoEvent -= turnBarco;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        BoteEndText.SetActive(false);
    }
}
