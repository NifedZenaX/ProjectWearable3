using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public string[] cardNames;
    public Button[] cards;
    // Start is called before the first frame update
    void Start()
    {
        foreach (string name in cardNames)
        {
            if (!PlayerPrefs.HasKey(name))
            {
                PlayerPrefs.SetInt(name, -1);
            }
        }

        foreach (Button card in cards)
        {
            if (PlayerPrefs.GetInt(card.name) == -1)
            {
                card.interactable = false;
            }
            else
            {
                card.interactable = true;
            }
        }
    }
}
