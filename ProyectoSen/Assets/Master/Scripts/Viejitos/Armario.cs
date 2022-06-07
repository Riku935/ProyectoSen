using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armario : MonoBehaviour
{
    public Animator animator;
    public bool isOpen;
    public bool isLock;
    public static bool isUnlocked;
    public bool isOn;
    public GameObject mensajeGuia;
    public GameObject encende;
    public GameObject Texto;
    public int triggerID;

    private void Start()
    {
        EventManager.openDoorEvent += useSimpleDoor;
    }
    public void useArmario()
    {
        if (isOpen)
        {
            closeArmario();
        }
        else
        {
            openArmario();
        }
    }
    public void useDoubleDoor()
    {
        if (isOpen)
        {
            closeDoubleDoor();
        }
        else
        {
            openDoubleDoor();
        }
    }

    public void useSimpleDoor(int triggerID)
    {
        if (isLock == true)
        {
            mensajeGuia.SetActive(true);
        }
        else if (isLock == false && isOpen == false)
        {
            openSimpleDoor();
        }
        else
        {
            closeSimpleDoor();
        }
    }
    
    public void useSwitch()
    {
        if (isOn)
        {
            turnOff();
        }
        else
        {
            turnOn();
        }
    }
    public void useBuro()
    {
        if (isOpen)
        {
            closeBuro();
        }
        else
        {
            openBuro();
        }
    }
    public void useKey()
    {
        Debug.Log("ya se abrio");
        this.gameObject.SetActive(false);
        EventManager.startdoorEvent(triggerID);
    }
    public void useChest()
    {
        if (isUnlocked == true)
        {
            openChest();
        }
        
    }
    public void useBed()
    {
        encende.transform.Rotate(-10,0,0);
    }
    public void useActivador()
    {
        encende.SetActive(false);
        activador();
    }




    void openChest()
    {
        
        animator.Play("AbriendoCofre");
    }
    void closeChest()
    {
        isOpen = false;
        animator.Play("CerrandoCofre");
    }

    void openArmario()
    {
        isOpen = true;
        animator.Play("Closet_Open");
    }
    void closeArmario()
    {
        isOpen = false;
        animator.Play("Closet_Close");
    }

    void openDoubleDoor()
    {
        isOpen = true;
        animator.Play("DDAbre");
    }
    void closeDoubleDoor()
    {
        isOpen = false;
        animator.Play("DDCierra");
    }
    void openSimpleDoor()
    {
        isOpen = true;
        animator.Play("DSAbre");
    }
    void closeSimpleDoor()
    {
        isOpen = false;
        animator.Play("DSCierra");
    }

    void openBuro()
    {
        isOpen = true;
        animator.Play("Abriendo");
    }
    void closeBuro()
    {
        isOpen = false;
        animator.Play("Cerrando");
    }

    void turnOn()
    {
        isOn = true;
        encende.SetActive(true);
    }
    void turnOff()
    {
        isOn = false;
        encende.SetActive(false);
    }

    void activador()
    {
        Texto.SetActive(true);
        new WaitForSecondsRealtime(5);
        Texto.SetActive(false);
    }
}
