using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuHandler : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;


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
        Debug.Log("Starting Game...");
    }


    IEnumerator delayPress(){
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    public void pressQuit(){
        StartCoroutine(quit());
        Debug.Log("Exiting Game...");
    }


    IEnumerator quit(){
        yield return new WaitForSeconds(1);
        Application.Quit();
    }


}
