using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameHandler1 : MonoBehaviour
{
    //Menu Button
    public GameObject startGame;

    public void pressStart(){
        StartCoroutine(delayPress());
        Debug.Log("Start");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator delayPress(){
        yield return new WaitForSeconds(2);
        Debug.Log("This is Delayed");
        SceneManager.LoadScene(1);
    }
}
