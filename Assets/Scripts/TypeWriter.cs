using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    Text dialogueBox;
    string dialogue;

    [Header("Typing rate")]
    public float typeRate = 0.25f;

    public void Type(string dialogue, Text textbox)
    {
        dialogueBox = textbox;
        dialogueBox.text = "";
        StartCoroutine(Typing(dialogue));
    }

    IEnumerator Typing(string text)
    {
        foreach(char c in text)
        {
            dialogueBox.text += c;

            yield return new WaitForSeconds(typeRate);
        }
    }
}
