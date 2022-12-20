using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public AudioSource source;
    public Animator anim;

    private void OnMouseDown()
    {
        source.Play();
        anim.SetTrigger("Interact");
    }
}
