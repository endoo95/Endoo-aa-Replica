using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
