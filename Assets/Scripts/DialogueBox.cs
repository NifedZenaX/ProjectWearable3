using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    public string[] dialogues;
    public Canvas dialogueCanvas;
    public Text textbox;

    TypeWriter typer;
    private void Awake()
    {
        typer = GetComponent<TypeWriter>();
    }

    public void InteractDialogue()
    {
        int rand = Random.Range(0, dialogues.Length);
        typer.Type(dialogues[rand], textbox);
        //textbox.text = dialogues[rand];
        return;
    }
}
