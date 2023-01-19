using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTrackHandler : MonoBehaviour
{

    public void ScanCard(GameObject image)
    {
        if(PlayerPrefs.GetInt(image.name) == -1)
        {
            PlayerPrefs.SetInt(image.name, 1);
        }
    }
}
