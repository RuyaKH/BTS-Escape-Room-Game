using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class zoomIn : MonoBehaviour
{
    public Button zoomInArea;
    public Button back;
    public Canvas zoomedArea;

    void Start()
    {
        zoomInArea = zoomInArea.GetComponent<Button>();
        zoomedArea = zoomedArea.GetComponent<Canvas>();
        back = back.GetComponent<Button>();

        zoomedArea.enabled = false;
        back.enabled = false;
    }

    public void GoToArea()
    {
        zoomedArea.enabled = true;
        back.enabled = true;
    }

    public void BackToRoom()
    {
        zoomedArea.enabled = false;
        back.enabled = false;
    }
}
