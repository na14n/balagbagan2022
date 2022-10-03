using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;


public class inputHandler : MonoBehaviour
{

    public static inputHandler inputsHandler;

    public int setHP;
    public string name1;
    public string name2;
    public int winResult;

    void Awake()
    {
        
        //hp
        if (inputsHandler == null) {
            inputsHandler = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
