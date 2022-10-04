using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class clickSound : MonoBehaviour
{

    public AudioClip clickOne;
    public AudioClip clickTwo;

    public AudioSource clickSfx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickSfxOne(){
        clickSfx.PlayOneShot(clickOne);
    }

    public void clickSfxTwo(){
        clickSfx.PlayOneShot(clickTwo);
    }

}
