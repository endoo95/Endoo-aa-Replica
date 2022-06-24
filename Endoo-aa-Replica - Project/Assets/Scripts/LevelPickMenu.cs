using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPickMenu : MonoBehaviour {

    public void PlayStandardGame()
    {
        PlayerPrefs.SetString("GameMode", "Standard");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayRouletteGame()
    {
        PlayerPrefs.SetString("GameMode", "Roulette");
        PlayerPrefs.SetInt("PinsCounter", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayNoSpinGame()
    {
        PlayerPrefs.SetString("GameMode", "NoSpin");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Debug.Log("Load NoSpinn Gamemode");
    }
}
