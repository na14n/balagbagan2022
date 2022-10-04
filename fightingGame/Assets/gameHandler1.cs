using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class gameHandler1 : MonoBehaviour
{
    //Player Name
    public static gameHandler1 playerName;
    public TMP_InputField inputField;
    public TMP_InputField inputField1;
    //public string name1;
    //public string name2;

    //Player HP
    public static gameHandler1 hpHandler1;
    public TMP_InputField hpSet;
    //public int maxHpSet;

    //Menu Button
     public GameObject startGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setVariable()
    {
        inputHandler.inputsHandler.name1 = inputField.text;
        inputHandler.inputsHandler.name2 = inputField1.text;
        inputHandler.inputsHandler.setHP = System.Convert.ToInt32(hpSet.text);
    }

    public void pressStart(){
        StartCoroutine(delayPress());
        setVariable();
        /* inputHandler.inputsHandler.maxHpSet = System.Convert.ToInt32(hpSet.text);
        name1 = inputField.text;
        name2 = inputField1.text; */
        Debug.Log(inputHandler.inputsHandler.setHP + " ");
        Debug.Log("Start");
    }

    IEnumerator delayPress(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }

    



    /* void Awake()
    {
        
        //hp
        if (hpHandler1 == null) {
            hpHandler1 = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }

        //name
        if (playerName == null) {
            playerName = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }
    } */

}
