using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Wall2 : MonoBehaviour
{
    public Button nextWall;

    void Start()
    {
        nextWall = nextWall.GetComponent<Button>();
    }

    public void GoToWall()
    {
        SceneManager.LoadScene("Wall 1");
    }
}