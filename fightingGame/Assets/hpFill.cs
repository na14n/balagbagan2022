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
    inputHandler hpInput;


    // Start is called before the first frame update
    void Start()
    {
        hpBar = GetComponent<Image>();
        gameHandler = GameObject.FindObjectOfType<newGameHandler2>();
        hpInput = GameObject.FindObjectOfType<inputHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        maxHP = hpInput.setHP;
        currentPlayerHP = gameHandler.player1HP;
        hpBar.fillAmount = currentPlayerHP/maxHP;
    }
}
