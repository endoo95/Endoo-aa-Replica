using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Text;
    public Text HText;
    
    private string _gameMode;

    public static int scorePoints;

    private void Awake()
    {
        _gameMode = PlayerPrefs.GetString("GameMode");
    }

    // Use this for initialization
    void Start () {

        scorePoints = 0;
        HText.text = PlayerPrefs.GetInt(_gameMode+"HighScore").ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt(_gameMode + "HighScore") < scorePoints)
        {
            PlayerPrefs.SetInt(_gameMode + "HighScore", scorePoints);
            HText.text = PlayerPrefs.GetInt(_gameMode + "HighScore").ToString();
        }

        Text.text = scorePoints.ToString();
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("StandardHighScore", 0);
        PlayerPrefs.SetInt("RouletteHighScore", 0);
        PlayerPrefs.SetInt("NoSPinHighScore", 0);
    }
}