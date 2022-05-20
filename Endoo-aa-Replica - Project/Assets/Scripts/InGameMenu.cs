using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject InGameMenuUI;
    public GameObject GameCanvas;
    public GameObject audioManager;

    private void Start()
    {
        audioManager = GameObject.Find("AudioManager");
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("wciśniey escape");
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

	}

    public void Resume()
    {
        InGameMenuUI.SetActive(false);
        GameCanvas.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        InGameMenuUI.SetActive(true);
        GameCanvas.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Destroy(audioManager);
        SceneManager.LoadScene(0);
    }
}

