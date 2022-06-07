using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Trigger : MonoBehaviour
{
    public GameObject interactText;
    public int triggerID;
    Keyboard actualkeyboard;
    private int interact;
    private void Start()
    {
        actualkeyboard = Keyboard.current;
    }
    void OnTriggerStay(Collider other)
    {
        
 
        if (other.tag == "Player" && actualkeyboard.eKey.wasPressedThisFrame) 
        {
            EventManager.startBoteEscenaEvent(triggerID);
            EventManager.startBoteEscena2Event(triggerID);
            EventManager.startBoteEscena3Event(triggerID);
            EventManager.startBoteEscena4Event(triggerID);
            EventManager.startBoteEscena5Event(triggerID);
            interactText.SetActive(false);
            //Primer Nivel
            EventManager.startdoorEvent(triggerID);
            EventManager.startTesoroEvent(triggerID);
            EventManager.startTVEvent(triggerID);
            EventManager.startPinturaEvent(triggerID);
            EventManager.startBoteEvent(triggerID);
            EventManager.startCoheteEvent(triggerID);
            EventManager.startBookEvent(triggerID);
            EventManager.startArbolEvent(triggerID);
            EventManager.startArbolEndEvent(triggerID);

            //Segundo Nivel
            EventManager.startArbol2Event(triggerID);
            EventManager.startArbolEnd2Event(triggerID);
            EventManager.startBarcoEvent(triggerID);
            EventManager.startSchoolEvent(triggerID);
            EventManager.startKitchenEvent(triggerID);

            //Tercer Nivel
            EventManager.startArbol3Event(triggerID);

            //this.gameObject.SetActive(false);

            //Cuarto Nivel
            EventManager.startArbol4Event(triggerID);
            EventManager.startArbol4EndEvent(triggerID);

            //Quinto Nivel
            EventManager.startArbol5Event(triggerID);
            EventManager.startArbol5EndEvent(triggerID);
        } 
        
    }
    private void OnTriggerEnter(Collider other)
    {
        interactText.SetActive(true);
        if (other.tag == "Balon")
        {
            Debug.Log("sirve");
            EventManager.startBalonEvent(triggerID);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        interactText.SetActive(false);
    }
}
