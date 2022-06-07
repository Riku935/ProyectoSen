using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class CambioEscena : MonoBehaviour
{
    public GameObject menu;
    public GameObject levelss;
    public GameObject settingss;
    [SerializeField] private AudioMixer audioMixer;
    public void uno()
    {
        SceneManager.LoadScene(0);
    }
    public void dos()
    {
        SceneManager.LoadScene(1);
    }
    public void tres()
    {
        SceneManager.LoadScene(2);
    }
    public void cuatro()
    {
        SceneManager.LoadScene(3);
    }
    public void cinco()
    {
        SceneManager.LoadScene(4);
    }
    public void levels()
    {
        menu.SetActive(false);
        levelss.SetActive(true);
    }
    public void settings()
    {
        menu.SetActive(false);
        settingss.SetActive(true);
    }
    public void cerrar()
    {
        menu.SetActive(true);
        levelss.SetActive(false);
    }
    public void cerrar2()
    {
        menu.SetActive(true);
        settingss.SetActive(false);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void aaudio(float sliderMusica)
    {
        audioMixer.SetFloat("Volumen", Mathf.Log10(sliderMusica) * 20);
    }
}
