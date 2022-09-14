using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class intro : MonoBehaviour
{
    public Button playGame;
    public float videoTimer = 82;
    public bool videoTimerIsRunning = false;

    void Start()
    {
        playGame = playGame.GetComponent<Button>();
        videoTimerIsRunning = true;
    }

    public void startGame()
    {
        SceneManager.LoadScene("Wall 1");
    }

    void Update()
    {
        if (videoTimerIsRunning)
        {
            if (videoTimer > 0)
            {
                videoTimer -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out");
                videoTimer = 0;
                videoTimerIsRunning = false;
                SceneManager.LoadScene("Wall 1");
            }
        }
    }
}
