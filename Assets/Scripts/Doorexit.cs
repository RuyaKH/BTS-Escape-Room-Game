using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Doorexit : MonoBehaviour
{
    public Button doorButton;
    public GameObject doorQuestion;
    public GameObject doorNotAvailable;

    public Button A;
    public Button B;
    public Button C;
    public Button closeMessageWrong;
    public GameObject wrongMessage;

    void Start()
    {
        A = A.GetComponent<Button>();
        B = B.GetComponent<Button>();
        C = C.GetComponent<Button>();
        doorButton = doorButton.GetComponent<Button>();
        closeMessageWrong = closeMessageWrong.GetComponent<Button>();
        //if (timer = 0)
        // SceneManagement.LoadScene("BadEnd");
    }

    public void GoToArea()
    {
        if (Inventory.inventory != 7)
        {
            doorQuestion.SetActive(false);
            doorNotAvailable.SetActive(true);
        }
        else if (Inventory.inventory == 7)
        {
            doorQuestion.SetActive(true);

        }
    }

    public void Right()
    {
        Debug.Log("Right answer selected");
        SceneManager.LoadScene("GoodEnd");
    }

    public void Wrong()
    {
        Debug.Log("Wrong answer selected");
        doorQuestion.SetActive(false);
        wrongMessage.SetActive(true);
    }

    public void BackToRoom()
    {
        doorQuestion.SetActive(false);
        doorNotAvailable.SetActive(false);
        wrongMessage.SetActive(false);
    }
}
