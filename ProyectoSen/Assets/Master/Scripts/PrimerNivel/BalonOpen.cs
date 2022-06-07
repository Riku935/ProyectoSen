using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOpen : MonoBehaviour
{
    public GameObject chestEndText;
    public int ObjectId;
    private bool isActivated = false;
    void Start()
    {
        EventManager.BalonEvent += winBalon;
    }

    void Update()
    {
        
    }
    private void balonStage()
    {
        if (isActivated == true)
        {
            chestEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
        }
    }

    private void winBalon(int triggerID)
    {
        if (triggerID == ObjectId)
        {
            isActivated = true;
            balonStage();
        }
    }

    private void OnDisable()
    {
        EventManager.openDoorEvent -= winBalon;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        chestEndText.SetActive(false);
    }
}
