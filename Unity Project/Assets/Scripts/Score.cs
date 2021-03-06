﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Text;
    public Text HText;

    public static int scorePoints;

	// Use this for initialization
	void Start () {
        scorePoints = 0;
        HText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("HighScore") < scorePoints)
        {
            PlayerPrefs.SetInt("HighScore", scorePoints);
            HText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }

        Text.text = scorePoints.ToString();
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}