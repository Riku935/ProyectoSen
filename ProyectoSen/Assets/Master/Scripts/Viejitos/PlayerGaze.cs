using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace com.Amerike.outside
{
    public class PlayerGaze : MonoBehaviour
    {
        void Update()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                PlayerGazeInfo.gazeObj = hit.transform.gameObject;
            }
            else
            {
                PlayerGazeInfo.gazeObj = null;
            }
        }

    }
}
