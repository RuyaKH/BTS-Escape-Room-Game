using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ExitGame : MonoBehaviour
{
    public Button exitButton;

    void Start()
    {
        exitButton = exitButton.GetComponent<Button>();

        //if (timer = 0)
        // SceneManagement.LoadScene("BadEnd");
    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }

}
