using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject mainTheme;

    public AudioMixer musicMixer;
    public AudioMixer fxMixer;

    public Toggle musicToggle;
    public Toggle fxToggle;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(mainTheme, transform);

        if (PlayerPrefs.GetInt("MuteMusic") == 0)
        {
            musicToggle.isOn = true;
            musicMixer.SetFloat("musicvolume", 0);
        }
        else
        {
            musicToggle.isOn = false;
            musicMixer.SetFloat("musicvolume", -80);
        }

        if (PlayerPrefs.GetInt("MuteSoundFx") == 0)
        {
            fxToggle.isOn = true;
            fxMixer.SetFloat("soundfxvolume", 0);
        }
        else
        {
            fxToggle.isOn = false;
            fxMixer.SetFloat("soundfxvolume", -80);
        }
        Debug.Log(PlayerPrefs.GetInt("MuteMusic"));
        Debug.Log(PlayerPrefs.GetInt("MuteSoundFx"));
    }

    public void MusicToggle()
    {
        Debug.Log("MusicToggle");
        if (musicToggle.isOn)
        {
            musicMixer.SetFloat("musicvolume", 0);
            PlayerPrefs.SetInt("MuteMusic", 0);
        }
        else
        {
            musicMixer.SetFloat("musicvolume", -80);
            PlayerPrefs.SetInt("MuteMusic", 1);
        }
    }

    public void FxToggle()
    {
        Debug.Log("FxToggle");
        if (fxToggle.isOn)
        {
            fxMixer.SetFloat("soundfxvolume", 0);
            PlayerPrefs.SetInt("MuteSoundFx", 0);
        }
        else
        {
            fxMixer.SetFloat("soundfxvolume", -80);
            PlayerPrefs.SetInt("MuteSoundFx", 1);
        }
    }
}
