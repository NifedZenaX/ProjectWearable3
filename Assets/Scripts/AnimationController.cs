using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    public DialogueBox dialogue;

    private void OnMouseDown()
    {
        anim.SetTrigger("Interact");
        dialogue.InteractDialogue();
    }
}
