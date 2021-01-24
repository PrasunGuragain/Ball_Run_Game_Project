﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevel;

    public void CompleteLevel()
    {
        completeLevel.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
