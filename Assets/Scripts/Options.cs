using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
       
        Screen.fullScreen = isFullscreen;
    }

    public void SetresHigh(bool isFullscreen)
    {
        isFullscreen = Screen.fullScreen;
        Screen.SetResolution(1920,1080,isFullscreen);
    }

    public void SetresMedium(bool isFullscreen)
    {     
        isFullscreen = Screen.fullScreen; 
        Screen.SetResolution(1024,768,isFullscreen);
    }

    public void SetresLow(bool isFullscreen)
    {
        isFullscreen = Screen.fullScreen;
        Screen.SetResolution(640,480,isFullscreen);
    }
}