using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpFill : MonoBehaviour
{

    private Image hpBar;
    public float currentPlayerHP = 100f;
    private float maxHP = 100f;
    newGameHandler2 gameHandler;
    gameHandler1 setHp;


    // Start is called before the first frame update
    void Start()
    {
        hpBar = GetComponent<Image>();
        gameHandler = GameObject.FindObjectOfType<newGameHandler2>();
        setHp = GameObject.FindObjectOfType<gameHandler1>();
    }

    // Update is called once per frame
    void Update()
    {
        maxHP = setHp.maxHpSet;
        currentPlayerHP = gameHandler.player1HP;
        hpBar.fillAmount = currentPlayerHP/maxHP;
    }
}
