using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    public Canvas dialogueCanvas;
    public Text textbox;

    TypeWriter typer;
    private void Awake()
    {
        typer = GetComponent<TypeWriter>();
    }

    public void InteractDialogue(string dialogue)
    {
        typer.Type(dialogue, textbox);
        return;
    }
}
