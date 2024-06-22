using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOptionSettings : MonoBehaviour
{
    public AudioMixer audioMixerMusica;
    public AudioMixer audioMixerEfects;

    public void SetVolume (float volume)
    {
        audioMixerMusica.SetFloat("volume", volume);
    }
    public void SetEfects(float volume)
    {
        audioMixerEfects.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullScreen(bool isfullScreen)
    {
        Screen.fullScreen = isfullScreen;
    }
}
