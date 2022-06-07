using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace com.Amerike.outside
{
    public class ElPlayer : MonoBehaviour
    {
        Keyboard actualkeyboard;
        Mouse actualMouse;
        Gamepad actualControl;
        void Start()
        {
            prepare();
        }
        void Update()
        {
            checkInput();
        }
        public void prepare()
        {
            actualkeyboard = Keyboard.current;
            actualMouse = Mouse.current;
            actualControl = Gamepad.current;
        }
        void OnJump()
        {
            print("Jump");
        }
        public void checkInput()
        {
            if (actualMouse.leftButton.wasPressedThisFrame)
            {
                Interact();
                
            }
        }
        void Interact()
        {
            if (PlayerGazeInfo.gazeObj != null)
            {
                Usable obj =
                    PlayerGazeInfo.gazeObj.GetComponent<Usable>();
                if(obj != null)
                {
                    obj.Use();
                }
            }
        }
    }
}
