using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class EventManager : MonoBehaviour
{
    //General
    public static event Action <int>BoteEscenaEvent;
    public static event Action<int> BoteEscena2Event;
    public static event Action<int> BoteEscena3Event;
    public static event Action<int> BoteEscena4Event;
    public static event Action<int> BoteEscena5Event;
    //Primer Nivel
    public static event Action ExampleEvent;
    public static event Action<int> tesoroEvent;
    public static event Action<int> BalonEvent;
    public static event Action<int> TVEvent;
    public static event Action<int> PinturaEvent;
    public static event Action<int> BoteEvent;
    public static event Action<int> CoheteEvent;
    public static event Action<int> BookEvent;
    public static event Action<int> ArbolEvent;
    public static event Action<int> ArbolEndEvent;
    public static event Action<int> openDoorEvent;

    //Segundo Nivel
    public static event Action<int> Arbol2Event;
    public static event Action<int> ArbolEnd2Event;
    public static event Action<int> BarcoEvent;
    public static event Action<int> SchoolEvent;
    public static event Action<int> KitchenEvent;

    //Tercer Nivel
    public static event Action<int> Arbol3Event;

    //Cuarto Nivel
    public static event Action<int> Arbol4Event;
    public static event Action<int> Arbol4EndEvent;

    //Quinto Nivel
    public static event Action<int> Arbol5Event;
    public static event Action<int> Arbol5EndEvent;


    Keyboard actualkeyboard;

    private void Start()
    {
        actualkeyboard = Keyboard.current;
    }
    private void Update()
    {

    }

    public static void startBoteEscenaEvent(int id)
    {
        BoteEscenaEvent?.Invoke(id);
    }
    public static void startBoteEscena2Event(int id)
    {
        BoteEscena2Event?.Invoke(id);
    }
    public static void startBoteEscena3Event(int id)
    {
        BoteEscena3Event?.Invoke(id);
    }
    public static void startBoteEscena4Event(int id)
    {
        BoteEscena4Event?.Invoke(id);
    }
    public static void startBoteEscena5Event(int id)
    {
        BoteEscena5Event?.Invoke(id);
    }
    //Primer nivel
    public static void startdoorEvent(int id)
    {
        openDoorEvent?.Invoke(id);
    }
    public static void startTesoroEvent(int id)
    {
        tesoroEvent?.Invoke(id);
    }
    public static void startBalonEvent(int id)
    {
        BalonEvent?.Invoke(id);
    }
    public static void startTVEvent(int id)
    {
        TVEvent?.Invoke(id);
    }
    public static void startPinturaEvent(int id)
    {
        PinturaEvent?.Invoke(id);
    }
    public static void startBoteEvent(int id)
    {
        BoteEvent?.Invoke(id);
    }
    public static void startCoheteEvent(int id)
    {
        CoheteEvent?.Invoke(id);
    }
    public static void startBookEvent(int id)
    {
        BookEvent?.Invoke(id);
    }
    public static void startArbolEvent(int id)
    {
        ArbolEvent?.Invoke(id);
    }
    public static void startArbolEndEvent(int id)
    {
        ArbolEndEvent?.Invoke(id);
    }
    public static void exampleEvent()
    {
        ExampleEvent?.Invoke();
    }

    //Segundo Nivel
    public static void startArbol2Event(int id)
    {
        Arbol2Event?.Invoke(id);
    }
    public static void startArbolEnd2Event(int id)
    {
        ArbolEnd2Event?.Invoke(id);
    }

    public static void startBarcoEvent(int id)
    {
        BarcoEvent?.Invoke(id);
    }
    public static void startSchoolEvent(int id)
    {
        SchoolEvent?.Invoke(id);
    }
    public static void startKitchenEvent(int id)
    {
        KitchenEvent?.Invoke(id);
    }

    //Tercer Nivel
    public static void startArbol3Event(int id)
    {
        Arbol3Event?.Invoke(id);
    }

    //CuartoNivel
    public static void startArbol4Event(int id)
    {
        Arbol4Event?.Invoke(id);
    }
    public static void startArbol4EndEvent(int id)
    {
        Arbol4EndEvent?.Invoke(id);
    }

    //QuintoNivel
    public static void startArbol5Event(int id)
    {
        Arbol5Event?.Invoke(id);
    }
    public static void startArbol5EndEvent(int id)
    {
        Arbol5EndEvent?.Invoke(id);
    }
}
