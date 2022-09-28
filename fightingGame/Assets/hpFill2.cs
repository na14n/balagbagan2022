using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpFill2 : MonoBehaviour
{
    private Image hpBar2;
    public float currentPlayer2HP;
    private float maxHP;
    newGameHandler2 gameHandler;
    gameHandler1 setHp;

    
    // Start is called before the first frame update
    void Start()
    {
        hpBar2 = GetComponent<Image>();
        gameHandler = GameObject.FindObjectOfType<newGameHandler2>();
        setHp = GameObject.FindObjectOfType<gameHandler1>();
    }

    // Update is called once per frame
    void Update()
    {
        maxHP = setHp.maxHpSet;
        currentPlayer2HP = gameHandler.player2HP;
        hpBar2.fillAmount = currentPlayer2HP/maxHP;
    }
}
