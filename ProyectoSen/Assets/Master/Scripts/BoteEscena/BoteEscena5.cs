using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoteEscena5 : MonoBehaviour
{
    public int objectId1;
    private bool isActivated = false;
    private bool isTurnOn;
    public Animator anim;
    private void Start()
    {
        EventManager.BoteEscena5Event += turnBote5;
    }
    private void BoteStage5()
    {
        if (isActivated == true && !isTurnOn)
        {
            anim.Play("Finals");
            StartCoroutine(wastingTime(20f));
            //SceneManager.LoadScene(6);
            isTurnOn = true;
        }
    }
    private void turnBote5(int TriggerID)
    {
        if (TriggerID == objectId1)
        {
            isActivated = true;
            BoteStage5();
        }
    }
    private void OnDisable()
    {
        EventManager.BoteEscena5Event -= turnBote5;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(6);
    }
}
