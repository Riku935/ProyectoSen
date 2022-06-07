using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOpen : MonoBehaviour
{
    public Transform movePoint;
    private bool open = false;
    public int doorID;
    void Start()
    {
        EventManager.openDoorEvent += OpenDoor;
    }

    void Update()
    {
        if(open == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, 5 * Time.deltaTime);
        }
    }

    private void OpenDoor(int triggerID)
    {
        if(triggerID == doorID)
        {
            open = true;
        }
        
    }
    private void OnDisable()
    {
        EventManager.openDoorEvent -= OpenDoor;
    }
}
