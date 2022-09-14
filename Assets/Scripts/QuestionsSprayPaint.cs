using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class QuestionsSprayPaint : MonoBehaviour
{
    public Button A;
    public Button B;
    public Button C;
    public Button closeMessageRight;
    public Button closeMessageLeft;

    public GameObject Question;
    public GameObject desk;
    public GameObject shelf;
    public GameObject drawer;
    public GameObject RightMessage;
    public GameObject WrongMessage;
    public GameObject spraypaint;

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
        desk.SetActive(false);
        shelf.SetActive(false);
        drawer.SetActive(false);
        RightMessage.SetActive(true);
        spraypaint.SetActive(true);
    }

    public void Wrong()
    {
        Debug.Log("Wrong answer selected");
        Question.SetActive(false);
        desk.SetActive(false);
        shelf.SetActive(false);
        drawer.SetActive(false);
        WrongMessage.SetActive(true);
    }

    public void BackToRoom()
    {
        RightMessage.SetActive(false);
        WrongMessage.SetActive(false);
    }
}