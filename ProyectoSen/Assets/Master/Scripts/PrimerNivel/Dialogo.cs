using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    [TextArea(5, 10)]
    public string[] lines;
    public float textSpeed;
    Keyboard actualkeyboard;
    private int index;
    private void Start()
    {
        textComponent.text = string.Empty;
        startDialogue();
        actualkeyboard = Keyboard.current;
    }
    private void Update()
    {
        if (actualkeyboard.qKey.wasPressedThisFrame)
        {
            if (textComponent.text == lines[index])
            {
                nextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void startDialogue()
    {
        index = 0;
        StartCoroutine(typeLine());
    }
    IEnumerator typeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void nextLine()
    {
        if (index < lines.Length -1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(typeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
