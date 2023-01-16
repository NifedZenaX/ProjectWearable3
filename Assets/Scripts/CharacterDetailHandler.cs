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
        go.transform.localScale = new Vector3(2.8f, 2.8f, 2.8f);

        int dialogueCnt = character.dialogues.Length;

        for (int i = 0; i < dialogueCnt; i++)
        {
            GameObject dialogueGo = Instantiate(dialoguePrefab, dialoguePrefabParent);
            // Get dialogue text from scriptable object and display
            Text dialogueTxt = dialogueGo.GetComponentInChildren<Text>();
            dialogueTxt.text = character.dialogues[i].dialogueText;

            // Get button and attach play dialogue method to button
            Button dialogueBtn = dialogueGo.GetComponentInChildren<Button>();
            dialogueBtn.onClick.AddListener(delegate { PlayAudio(character.dialogues[i].sound.dialogueName); });
        }
    }

    public void PlayAudio(string dialogueName)
    {
        foreach (ChracterSO.Dialogues dialogue in character.dialogues)
        {
            if (dialogue.sound.dialogueName.Equals(dialogueName))
            {
                go.GetComponent<AudioSource>().clip = dialogue.sound.dialogueSFX;
                break;
            }
        }
        go.GetComponent<AudioSource>().Play();
    }

    public void PlayAnimation()
    {
        go.GetComponent<Animator>().SetTrigger("Interact");
    }
}
