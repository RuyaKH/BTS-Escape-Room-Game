using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class timer : MonoBehaviour
{
    //public Button playGame
    public float gameTimer = 900;
    public bool gameTimerIsRunning = false;

    void Start()
    {
        ///playGame = playGame.GetComponent<Button>();
        gameTimerIsRunning = true;
    }

    //public void endGame()
    //{
    //    SceneManager.LoadScene("BadEnd");
    //}

    void Update()
    {
        if (gameTimerIsRunning)
        {
            if (gameTimer > 0)
            {
                gameTimer -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out");
                gameTimer = 0;
                gameTimerIsRunning = false;
                SceneManager.LoadScene("BadEnd");
            }
        }
    }
}