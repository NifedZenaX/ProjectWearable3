using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDetailHandler : MonoBehaviour
{
    public Text charName;
    public Transform charBase;

    public GameObject dialoguePrefab;
    public Transform dialoguePrefabParent;

    public AppManager manager;

    GameObject go;
    ChracterSO character;

    public void Start()
    {
        //character = manager.character;
        character = AppManager.instance.character;
        charName.text = character.charName;
        go = Instantiate(character.character, charBase);
        go.GetComponent<CapsuleCollider>().enabled = false;
        go.transform.localScale = new Vector3(350f, 350f, 350f);
        go.transform.localPosition = new Vector3(go.transform.position.x, go.transform.position.y, -500f);

        int dialogueCnt = character.dialogues.Length;

        for (int i = 0; i < dialogueCnt; i++)
        {
            GameObject dialogueGo = Instantiate(dialoguePrefab, dialoguePrefabParent);
            // Get dialogue text from scriptable object and display
            Text dialogueTxt = dialogueGo.GetComponentInChildren<Text>();
            dialogueTxt.text = character.dialogues[i].dialogueText;

            // Get button and attach play dialogue method to button
            Button dialogueBtn = dialogueGo.GetComponentInChildren<Button>();
            dialogueBtn.onClick.AddListener(delegate { PlayAudio(character.dialogues[i].sound.dialogueSFX); });
        }
    }

    public void PlayAudio(AudioClip dialogue)
    {
        AudioSource src = go.GetComponent<AudioSource>();
        src.clip = dialogue;
        src.Play();
    }

    public void PlayAnimation()
    {
        go.GetComponent<Animator>().SetTrigger("Interact");
    }
}
