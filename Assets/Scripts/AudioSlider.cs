using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    Slider audioSlider;
    AudioSource source;

    public void Start()
    {
        source = GetComponent<AudioSource>();
        audioSlider = GetComponent<Slider>();
        audioSlider.maxValue = source.clip.length;
    }

    public void Update()
    {
    }

    public void PlaySlider()
    {
        source.Play();
        audioSlider.value = 0;
        while(audioSlider.value != audioSlider.maxValue)
        {
            audioSlider.value += source.time;
        }
    }
}
