using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteOpen : MonoBehaviour
{
    public GameObject CoheteEndText;
    public Animator Anim;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.CoheteEvent += turnCohete;
    }
    private void Update()
    {

    }
    private void CoheteStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            Anim.Play("Cohete");
            CoheteEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnCohete(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            CoheteStage();
        }
    }
    private void OnDisable()
    {
        EventManager.CoheteEvent -= turnCohete;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        CoheteEndText.SetActive(false);
    }
}
