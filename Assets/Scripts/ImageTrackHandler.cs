using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageTrackHandler : MonoBehaviour, IPointerDownHandler
{
    public GameObject congratsPanel;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (congratsPanel.activeInHierarchy)
        {
            congratsPanel.SetActive(false);
        }
    }

    public void ScanCard(GameObject image)
    {
        if(PlayerPrefs.GetInt(image.name) == -1)
        {
            congratsPanel.SetActive(true);
            PlayerPrefs.SetInt(image.name, 1);
        }
    }
}
