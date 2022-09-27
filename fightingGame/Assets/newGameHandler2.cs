using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGameHandler2 : MonoBehaviour 
{

    // Player HP
    public GameObject player1HPUI;
    public GameObject player2HPUI;

    public int player1HP = 100;
    public int player2HP = 100;

    //Delay System
    public IEnumerator delaySystem(int damageAmount, float accuracy, int playerHP, int playerN, int delayATK, int delayMISS){
        int x = Random.Range(1,101);
        if (playerN == 1)
        {
            if (x <=accuracy)
            {
                yield return new WaitForSeconds(delayATK);
                playerHP -= damageAmount;
                player2HP = playerHP;
                Debug.Log("Player 2 dealt " + damageAmount + " damage.");
            }
            else
            {
                yield return new WaitForSeconds(delayMISS);
                Debug.Log("Player 1 attack missed. ");
            }
        }
        if (playerN == 2)
        {
            if (x <=accuracy)
            {
                yield return new WaitForSeconds(delayATK);
                playerHP -= damageAmount;
                player1HP = playerHP;
                Debug.Log("Player 1 dealt " + damageAmount + " damage.");
            }
            else
            {
                yield return new WaitForSeconds(delayMISS);
                Debug.Log("Player 2 attack missed. ");
            }
        }
    }

    //Attack Buttons
    public void p1LowPunch()
    {
        StartCoroutine(delaySystem(3,75,player2HP,1,2,2));
        Debug.Log("Player 1 used LowPunch.");
    }

    public void p1HighPunch()
    {
        StartCoroutine(delaySystem(8,55,player2HP,1,3,2));
        Debug.Log("Player 1 used HighPunch.");
    }

    public void p1LowKick()
    {
        StartCoroutine(delaySystem(6,65,player2HP,1,2,2));
        Debug.Log("Player 1 used LowKick.");
    }

    public void p1HighKick()
    {
        StartCoroutine(delaySystem(12,45,player2HP,1,3,2));
        Debug.Log("Player 1 used HighKick.");
    }

    public void p1Special()
    {
        StartCoroutine(delaySystem(25,101,player2HP,1,5,3));
        Debug.Log("Player 1 used Special.");
    }

    public void p2LowPunch()
    {
        StartCoroutine(delaySystem(3,75,player1HP,2,2,2));
        Debug.Log("Player 2 used LowPunch.");
    }

    public void p2HighPunch()
    {
        StartCoroutine(delaySystem(8,55,player1HP,2,3,2));
        Debug.Log("Player 2 used HighPunch.");
    }

    public void p2LowKick()
    {
        StartCoroutine(delaySystem(6,65,player1HP,2,2,2));
        Debug.Log("Player 2 used LowKick.");
    }

    public void p2HighKick()
    {
        StartCoroutine(delaySystem(12,45,player1HP,2,3,2));
        Debug.Log("Player 2 used HighKick.");
    }
    public void p2Special()
    {
        StartCoroutine(delaySystem(25,101,player1HP,2,5,3));
        Debug.Log("Player 2 used Special.");
    }

    /* public void p2HighPunch()
    {
        StartCoroutine(delaySystem( Attack Damage, Attack Accuracy, kaninong HP mababawasan, sino umatake,delay ng atk, delay ng miss));
        Debug.Log("Player 1 used HighPunch.");
    } */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player1HP + "";
        player2HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player2HP + "";
    }
}
