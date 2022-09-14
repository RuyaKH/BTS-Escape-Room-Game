using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class QuestionsLighter : MonoBehaviour
{
    public Button A;
    public Button B;
    public Button C;
    public Button closeMessageRight;
    public Button closeMessageWrong;

    public GameObject Question;
    public GameObject shelf;
    public GameObject RightMessage;
    public GameObject WrongMessage;
    public GameObject lighter;

    void Start()
    {
        A = A.GetComponent<Button>();
        B = B.GetComponent<Button>();
        C = C.GetComponent<Button>();
    }

    public void Right()
    {
        Debug.Log("Right answer selected");
        Question.SetActive(false);
        shelf.SetActive(false);
        RightMessage.SetActive(true);
        lighter.SetActive(true);
    }

    public void Wrong()
    {
        Debug.Log("Wrong answer selected");
        Question.SetActive(false);
        shelf.SetActive(false);
        WrongMessage.SetActive(true);
    }

    public void BackToRoom()
    {
        RightMessage.SetActive(false);
        WrongMessage.SetActive(false);
    }
}