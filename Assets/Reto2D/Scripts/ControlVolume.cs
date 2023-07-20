using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlVolume : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Slider sliderSet;

    private void Start()
    {
        float sliderValue = sliderSet.value;
        volumeSlider.value = audioSource.volume;
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}