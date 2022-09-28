using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpFill2 : MonoBehaviour
{
    private Image hpBar2;
    public float currentPlayer2HP;
    private float maxHP = 100f;
    newGameHandler2 gameHandler; 

    
    // Start is called before the first frame update
    void Start()
    {
        hpBar2 = GetComponent<Image>();
        gameHandler = GameObject.FindObjectOfType<newGameHandler2>();
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayer2HP = gameHandler.player2HP;
        hpBar2.fillAmount = currentPlayer2HP/maxHP;
    }
}
