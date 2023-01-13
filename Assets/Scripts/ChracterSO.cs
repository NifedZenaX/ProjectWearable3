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

    [System.Serializable]
    public struct Dialogues
    {
        public string dialogueText;
        [System.Serializable]
        public struct DialogueSound
        {
            public string dialogueName;
            public AudioClip dialogueSFX;
        };
        public DialogueSound sound;
    };

    public Dialogues[] dialogues;
}
