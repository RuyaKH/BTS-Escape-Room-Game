using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class zoomInDesk : MonoBehaviour
{
    public Button zoomInArea;
    public Button back;

    public GameObject areaZoomed;

    void Start()
    {
        zoomInArea = zoomInArea.GetComponent<Button>();
        back = back.GetComponent<Button>();
    }

    public void GoToArea()
    {
        areaZoomed.SetActive(true);
        //back.SetActive(true);
    }

    public void BackToRoom()
    {
        areaZoomed.SetActive(false);
        //back.SetActive(false);
    }
}
