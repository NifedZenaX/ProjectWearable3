using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;

    public DialogueBox dialogue;

    private void OnMouseDown()
    {
        if (anim.GetBool("Interact"))
        {
            anim.SetBool("Interact", false);
        }
        else
        {
            anim.SetBool("Interact", true);
        }
        dialogue.InteractDialogue();
    }
}
