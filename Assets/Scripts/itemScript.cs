using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class itemScript : MonoBehaviour
{
    public Button itemButton;

    public GameObject cupboardDoor;
    public GameObject clothes;
    public GameObject itemImage;

    void Start()
    {
        itemButton = itemButton.GetComponent<Button>();
    }

    public void collectItem()
    {
        cupboardDoor.SetActive(false);
        clothes.SetActive(false);
        itemImage.SetActive(true);
    }
}