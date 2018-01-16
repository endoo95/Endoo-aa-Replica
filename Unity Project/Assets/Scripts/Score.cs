using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Text;
    public Text HText;

    public static int scorePoints;
    public static int hScorePoints = 0;

	// Use this for initialization
	void Start () {
        scorePoints = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (hScorePoints < scorePoints)
        {
            hScorePoints = scorePoints;
        }

        Text.text = scorePoints.ToString();
        HText.text = hScorePoints.ToString();
    }
}