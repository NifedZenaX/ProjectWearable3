using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterController : MonoBehaviour
{
    public AudioSource source;
    public Animator anim;
    public ChracterSO character;
    public DialogueBox? dialogueBox;
    private void OnMouseDown()
    {
        source.Play();
        anim.SetTrigger("Interact");
        dialogueBox.InteractDialogue(character.dialogues[0].dialogueText);
    }
}
