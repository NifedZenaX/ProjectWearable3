using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class ChracterSO : ScriptableObject
{
    public GameObject character;
    public string charName;
    public Animator charAnim;
    public AudioSource charAudio;
    public string[] dialogues;
}
