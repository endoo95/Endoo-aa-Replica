using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool gameEnded = false;

    public Animator animator;

    public Circle_Rotate circle;
    public Spawner spawnPoint;

    public void GameEnded()
    {

        if (gameEnded)
            return;

        circle.enabled = false;
        spawnPoint.enabled = false;

        animator.SetTrigger("EndGame");

        gameEnded = true;

    }
}
