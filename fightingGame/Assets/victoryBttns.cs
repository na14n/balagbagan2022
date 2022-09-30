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
        StartCoroutine(delayPress());
        Debug.Log("Start");
    }

    IEnumerator delayPress(){
        yield return new WaitForSeconds(2);
        Debug.Log("This is Delayed");
        SceneManager.LoadScene(1);
    }
}
