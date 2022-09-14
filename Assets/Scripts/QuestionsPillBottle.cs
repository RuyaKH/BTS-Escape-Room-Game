using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class QuestionsPillBottle : MonoBehaviour
{
    public Button A;
    public Button B;
    public Button C;
    public Button closeMessageRight;
    public Button closeMessageLeft;
    public Button pickUpPills;

    public GameObject Question;
    public GameObject poster;
    public GameObject safeClosed;
    public GameObject safeOpen;
    public GameObject RightMessage;
    public GameObject WrongMessage;
    public GameObject Pills;

    void Start()
    {
        A = A.GetComponent<Button>();
        B = B.GetComponent<Button>();
        C = C.GetComponent<Button>();
        pickUpPills = pickUpPills.GetComponent<Button>();
    }

    public void Right()
    {
        Debug.Log("Right answer selected");
        Question.SetActive(false);
        poster.SetActive(false);
        safeClosed.SetActive(false);
        safeOpen.SetActive(false);
        RightMessage.SetActive(true);
    }

    public void Wrong()
    {
        Debug.Log("Wrong answer selected");
        Question.SetActive(false);
        poster.SetActive(false);
        safeClosed.SetActive(false);
        safeOpen.SetActive(false);
        WrongMessage.SetActive(true);
    }

    public void BackToRoom()
    {
        RightMessage.SetActive(false);
        WrongMessage.SetActive(false);
        safeOpen.SetActive(false);
    }

    public void GoToArea()
    {
        RightMessage.SetActive(false);
        safeOpen.SetActive(true);
    }

    public void PillIcon()
    {
        Pills.SetActive(true);
    }
}