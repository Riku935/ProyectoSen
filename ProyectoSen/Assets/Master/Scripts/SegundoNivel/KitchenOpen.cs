using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenOpen : MonoBehaviour
{
    public GameObject KitchenEndText;
    public GameObject efecto;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.KitchenEvent += turnKitchen;
    }
    private void Update()
    {

    }
    private void KitchenStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            KitchenEndText.SetActive(true);
            efecto.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnKitchen(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            KitchenStage();
        }
    }
    private void OnDisable()
    {
        EventManager.KitchenEvent -= turnKitchen;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        KitchenEndText.SetActive(false);
    }
}
