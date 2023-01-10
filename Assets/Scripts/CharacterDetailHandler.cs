using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDetailHandler : MonoBehaviour
{
    public Text charName;
    public Text charDialogues;
    public Transform charBase;

    ChracterSO character;

    public void Start()
    {
        character = AppManager.instance.character;
        charName.text = character.charName;
        GameObject go = Instantiate(character.character, charBase);
        go.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }

    public void PlayAudio()
    {
        character.charAudio.Play();
    }

    public void PlayAnimation()
    {
        character.charAnim.SetTrigger("Interact");
    }
}
