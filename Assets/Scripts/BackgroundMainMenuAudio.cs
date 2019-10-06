using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMainMenuAudio : MonoBehaviour
{
    public AudioClip musicClip;

    public AudioSource musicSource;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
        slider.value = musicSource.volume;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void VolumeChange()
    {
        musicSource.volume = slider.value;
    }
}
