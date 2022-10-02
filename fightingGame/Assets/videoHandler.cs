using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Video;


public class videoHandler : MonoBehaviour
{

    // Video Variables //

    public GameObject videoPlayerGO;
    public VideoClip vc;
    public VideoPlayer vp1;
    public VideoClip clip;
    public VideoClip defClip;


    // Start is called before the first frame update
    void Start()
    {
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = defClip;
        //videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        //videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = c;
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
    }

    public void play(){
        vp1.clip = vc;
        Invoke("defaultPlay",5);
    }

     public void play2(){
        vp1.clip = clip;
        Invoke("defaultPlay",2);
    }
    
    public void defaultPlay(){
        Debug.Log("default clip Played");
        vp1.clip = defClip;
    }

}
