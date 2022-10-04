using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoryBttns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressRestart(){
        StartCoroutine(restart());
        Debug.Log("Restarting Game...");
    }

    IEnumerator restart(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
    public void pressMainmenu(){
        StartCoroutine(mainMenudelay());
        Debug.Log("Returning to Main Menu...");
    }

    public void pressQuit(){
        StartCoroutine(exitGame());
        Debug.Log("Exiting Game...");
    }

    IEnumerator mainMenudelay(){
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }

    IEnumerator exitGame(){
        yield return new WaitForSeconds(1);
        Application.Quit();
    }



}
