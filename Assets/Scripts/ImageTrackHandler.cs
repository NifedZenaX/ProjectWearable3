using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageTrackHandler : MonoBehaviour
{
    public GameObject congratsPanel;
    public void ScanCard(GameObject image)
    {
        if(PlayerPrefs.GetInt(image.name) == -1)
        {
            congratsPanel.SetActive(true);
            PlayerPrefs.SetInt(image.name, 1);
        }
    }

    private void OnMouseDown()
    {
        if(congratsPanel.activeSelf == true)
        {
            congratsPanel.SetActive(false);
        }
    }
}
