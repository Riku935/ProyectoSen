using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookOpen : MonoBehaviour
{
    public GameObject BookEndText;
    public int objectId;
    private bool isActivated = false;
    private bool isTurnOn;
    private void Start()
    {
        EventManager.BookEvent += turnBook;
    }
    private void Update()
    {

    }
    private void BookStage()
    {
        if (isActivated == true && !isTurnOn)
        {
            BookEndText.SetActive(true);
            StartCoroutine(wastingTime(5f));
            isTurnOn = true;
        }
    }
    private void turnBook(int TriggerID)
    {
        if (TriggerID == objectId)
        {
            isActivated = true;
            BookStage();
        }
    }
    private void OnDisable()
    {
        EventManager.BookEvent -= turnBook;
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        BookEndText.SetActive(false);
    }
}
