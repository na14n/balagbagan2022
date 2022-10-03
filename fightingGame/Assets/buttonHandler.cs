using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class buttonHandler : MonoBehaviour
{

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

    public void pressStart(){
        StartCoroutine(delayPress());
        Debug.Log("Start");
    }

    IEnumerator delayPress(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
