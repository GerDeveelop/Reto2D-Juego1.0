using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlVolume : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider sliderSet;

    private void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat("Volumen", 1f);
        volumeSlider.value = savedVolume;

        UpdateAllAudioVolumes(savedVolume);

        // Agregar Listeners para controlar el volumen
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);
        sliderSet.onValueChanged.AddListener(OnSetSliderChanged);
    }

    private void OnVolumeSliderChanged(float volume)
    {
        UpdateAllAudioVolumes(volume);
        PlayerPrefs.SetFloat("Volumen", volume);
    }

    private void OnSetSliderChanged(float value)
    {
        volumeSlider.value = value;
    }

    private void UpdateAllAudioVolumes(float volume)
    {
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.volume = volume;
        }
    }
}