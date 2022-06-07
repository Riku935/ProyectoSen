using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoteOpen : MonoBehaviour
{
    public GameObject BoteEndText;
    public Animator Anim;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BoteEvent += turnBote;
    }
    private void Update()
    {
        
    }
    private void PinturaStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            Anim.Play("Bote");
            BoteEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnBote(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            PinturaStage();
        }
    }
    private void OnDisable()
    {
        EventManager.BoteEvent -= turnBote;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        BoteEndText.SetActive(false);
    }
}
