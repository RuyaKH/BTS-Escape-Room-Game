using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public GameObject item;
    public static int inventory = 0;

    void Start()
    {
        if (item.activeSelf == true)
        {
            inventory += 1;
            Debug.Log("Inventory: " + inventory);
        }
        else
        {
            Debug.Log("item not active");
        }

    }


}
