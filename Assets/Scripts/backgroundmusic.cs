using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class backgroundmusic : MonoBehaviour
{
    private float volume;
    public AudioSource audiosource;
    void Start()
    {
        volume = PlayerPrefs.GetFloat("volume");
        audiosource.volume = volume;
    }
}

