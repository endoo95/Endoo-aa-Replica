using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer musicMixer;
    public AudioMixer soundFXMixer;

    public void SetMusicVolume(float musicVolume)
    {
        musicMixer.SetFloat("musicvolume", musicVolume);
    }

    public void SetSoundFXVolume(float fxVolume)
    {
        soundFXMixer.SetFloat("soundfxvolume", fxVolume);
    }
}
