using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private bool isActivated = false;
    public GameObject chestEndText;
    public int ObjectId;
    public Animator anim;
    bool opened;
    void Start()
    {
        EventManager.tesoroEvent += openChest;
    }
    void Update()
    {
        
    }
    private void chestStage()
    {
        if (isActivated == true && !opened)
        {
            anim.Play("AbriendoCofre");
            chestEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
            opened = true;
        }
    }
    private void openChest(int triggerID)
    {
        if (triggerID == ObjectId)
        {
            isActivated = true;
            chestStage();
        }
    }
    private void OnDisable()
    {
        EventManager.openDoorEvent -= openChest; 
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        chestEndText.SetActive(false);
        isActivated = false;
    }
}
