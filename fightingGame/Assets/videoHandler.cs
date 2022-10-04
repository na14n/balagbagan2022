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

    public VideoPlayer videoPlayer;

    public TextMeshProUGUI p1Damage;
    public TextMeshProUGUI p2Damage;


    // Video Clips //

    public VideoClip defClip;

    public VideoClip p1Special;
    public VideoClip p1SpecialMiss;
    public VideoClip p1KickLow;
    public VideoClip p1KickLowMiss;
    public VideoClip p1KickHigh;
    public VideoClip p1KickHighMiss;
    public VideoClip p1PunchLow;
    public VideoClip p1PunchLowMiss;
    public VideoClip p1PunchHigh;
    public VideoClip p1PunchHighMiss;

    public VideoClip p2Special;
    public VideoClip p2SpecialMiss;
    public VideoClip p2KickLow;
    public VideoClip p2KickLowMiss;
    public VideoClip p2KickHigh;
    public VideoClip p2KickHighMiss;
    public VideoClip p2PunchLow;
    public VideoClip p2PunchLowMiss;
    public VideoClip p2PunchHigh;
    public VideoClip p2PunchHighMiss;
    



    private void Awake() 
    {
        videoPlayer.clip = defClip;
        videoPlayer.Play();
        DealtDamageClear();
    }


    // Start is called before the first frame update
    void Start()
    {
        //videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = defClip;
        //videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        //videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
        //videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = c;
    }

    // ---  ATTACK FUNCTIONS --- //

    // Player 1 Attacks

    public void p1SpecialPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p1SpecialMiss;
            Invoke("defaultPlay",3);
            Invoke("p1DealtDamage",2);
            Invoke("DealtDamageClear",3);
        }
        else
        {
            videoPlayer.clip = p1Special;
            Invoke("defaultPlay",5);
            Invoke("p1DealtDamage",4);
            Invoke("DealtDamageClear",5);
        } 
    }

    public void p1PunchLowPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p1PunchLowMiss;
            Invoke("defaultPlay",2);
            Invoke("p1DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p1PunchLow;
            Invoke("defaultPlay",2);
            Invoke("p1DealtDamage",1);
            Invoke("DealtDamageClear",2);
        } 
    }

    public void p1PunchHighPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p1PunchHighMiss;
            Invoke("defaultPlay",2);
            Invoke("p1DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p1PunchHigh;
            Invoke("defaultPlay",3);
            Invoke("p1DealtDamage",2);
            Invoke("DealtDamageClear",3);
        } 
    }

    public void p1KickLowPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p1KickLowMiss;
            Invoke("defaultPlay",2);
            Invoke("p1DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p1KickLow;
            Invoke("defaultPlay",2);
            Invoke("p1DealtDamage",1);
            Invoke("DealtDamageClear",2);
        } 
    }

    public void p1KickHighPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p1KickHighMiss;
            Invoke("defaultPlay",2);
            Invoke("p1DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p1KickHigh;
            Invoke("defaultPlay",3);
            Invoke("p1DealtDamage",2);
            Invoke("DealtDamageClear",3);
        } 
    }

    // Player 2 Attacks

    public void p2SpecialPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p2SpecialMiss;
            Invoke("defaultPlay",3);
            Invoke("p2DealtDamage",2);
            Invoke("DealtDamageClear",3);
        }
        else
        {
            videoPlayer.clip = p2Special;
            Invoke("defaultPlay",5);
            Invoke("p2DealtDamage",3);
            Invoke("DealtDamageClear",5);
        }
    }

    public void p2PunchLowPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p2PunchLowMiss;
            Invoke("defaultPlay",2);
            Invoke("p2DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p2PunchLow;
            Invoke("defaultPlay",2);
            Invoke("p2DealtDamage",1);
            Invoke("DealtDamageClear",2);
        } 
    }

    public void p2PunchHighPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p2PunchHighMiss;
            Invoke("defaultPlay",2);
            Invoke("p2DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p2PunchHigh;
            Invoke("defaultPlay",3);
            Invoke("p2DealtDamage",2);
            Invoke("DealtDamageClear",3);
        } 
    }

    public void p2KickLowPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p2KickLowMiss;
            Invoke("defaultPlay",2);
            Invoke("p2DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p2KickLow;
            Invoke("defaultPlay",2);
            Invoke("p2DealtDamage",1);
            Invoke("DealtDamageClear",2);
        } 
    }

    public void p2KickHighPlay()
    {
        if (newGameHandler2.isMiss == true)
        {
            videoPlayer.clip = p2KickHighMiss;
            Invoke("defaultPlay",2);
            Invoke("p2DealtDamage",1);
            Invoke("DealtDamageClear",2);
        }
        else
        {
            videoPlayer.clip = p2KickHigh;
            Invoke("defaultPlay",3);
            Invoke("p2DealtDamage",2);
            Invoke("DealtDamageClear",3);
        } 
    }


    // Idle Video or defaultPlay

    public void defaultPlay(){
        //Debug.Log("Default clip played");
        videoPlayer.clip = defClip;
    }


    // Damage Display

    public void p1DealtDamage(){
        if (newGameHandler2.isMiss == true)
        {   
            p1Damage.text = "Miss";
        }
        else
        {
            p2Damage.text = "- " + inputHandler.inputsHandler.p1Dealt;
        }
    }

    public void p2DealtDamage(){
        if (newGameHandler2.isMiss == true)
        {   
            p2Damage.text = "Miss";
        }
        else
        {
            p1Damage.text = "- " + inputHandler.inputsHandler.p2Dealt;
        }
    }

    public void DealtDamageClear(){
            p1Damage.text = "";
            p2Damage.text = "";
    }


    

}
