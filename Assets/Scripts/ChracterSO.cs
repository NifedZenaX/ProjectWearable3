using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class ChracterSO : ScriptableObject
{
    public Sprite charImage;
    public string charName;
    public string charDesc;

    public string[] dialogues;
}
