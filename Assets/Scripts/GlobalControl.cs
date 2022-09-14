using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public GameObject item;
    //public int inventory;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            //Debug.Log(inventory);
            //Instance = this;
        }
        //else if (Instance != this)
        //{
        //    Destroy(gameObject);
        //}
    }

    void Start()
    {
        item = GlobalControl.Instance.item;
        //inventory = GlobalControl.Instance.inventory;
    }

    public void SaveData()
    {
        GlobalControl.Instance.item = item;
        //GlobalControl.Instance.inventory = inventory;
    }

}
