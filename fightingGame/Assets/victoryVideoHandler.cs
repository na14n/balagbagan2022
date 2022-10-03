using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Video;
using UnityEngine.Audio;

public class victoryVideoHandler : MonoBehaviour
{

    public static victoryVideoHandler victoryVid;
    public int choice;
    public TextMeshProUGUI winnerName;

    // Video Variables //

    public GameObject videoPlayerGO;
    public VideoPlayer vp1;

    public AudioSource bgm;
    public AudioSource sfx;

    // Video Clips //
    public VideoClip t1Victory;
    public VideoClip t2Victory;

    public AudioClip victorySfx;
    public AudioClip victoryBgm1;
    public AudioClip victoryBgm2;
    public AudioClip sheesh;

    private void Awake() 
    {
        winner(inputHandler.inputsHandler.winResult);
        sfx.PlayOneShot(victorySfx);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void winner(int win){
        if (win == 1)
        {
            vp1.clip = t1Victory;
            bgm.clip = victoryBgm1;
            winnerName.text = inputHandler.inputsHandler.name1 + " Wins!";
            vp1.Play();
            bgm.Play();
            
        }
        else if(win == 2)
        {
            vp1.clip = t2Victory;
            bgm.clip = victoryBgm2;
            winnerName.text = inputHandler.inputsHandler.name2 + " Wins!";
            vp1.Play();
            bgm.Play();
            sfx.PlayOneShot(sheesh);
        }
    }

}
