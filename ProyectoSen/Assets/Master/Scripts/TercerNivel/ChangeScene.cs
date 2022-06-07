using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wastingTime(45));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator wastingTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Nivel3.5_Deprimido");
    }
}
