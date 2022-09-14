using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameHander2 : MonoBehaviour
{
    public GameObject player1HPUI;
    public GameObject player2HPUI;

    public int player1HP = 100;
    public int player2HP = 100;

    // Damage System
    void dealDamage(int damageAmount, float accuracy, int playerHP, int playerN)
    {
        int x = Random.Range(1,101);
        if (playerN == 2)
        {
            if (x <=accuracy)
            {
                playerHP -= damageAmount;
                player2HP = playerHP;
                Debug.Log("Player 1 dealt " + damageAmount + " damage.");
            }
            else
            {
                Debug.Log("Player 1 attack missed. ");
            }
        }
        if (playerN == 1)
        {
            if (x <=accuracy)
            {
                playerHP -= damageAmount;
                player1HP = playerHP;
                Debug.Log("Player 2 dealt " + damageAmount + " damage.");
            }
            else
            {
                Debug.Log("Player 2 attack missed. ");
            }
        }
    }

    // Attack Buttons Player 1
    public void p1LowPunch()
    {
        StartCoroutine(lowPunchP1());
        Debug.Log("Player 1 used LowPunch.");
    }
    public void p1HighPunch()
    {
        StartCoroutine(highPunchP1());
        Debug.Log("Player 1 used HighPunch.");
    }
    public void p1LowKick()
    {
        StartCoroutine(lowKickP1());
        Debug.Log("Player 1 used LowKick.");
    }
    public void p1HighKick()
    {
        StartCoroutine(highKickP1());
        Debug.Log("Player 1 used HighKick.");
    }
    public void p1Special()
    {
        StartCoroutine(specialP1());
        Debug.Log("Player 1 used Special.");
    }

    // Attack Buttons Player 2
    public void p2LowPunch()
    {
        StartCoroutine(lowPunchP2());
        Debug.Log("Player 2 used LowPunch.");
    }
    public void p2HighPunch()
    {
        StartCoroutine(highPunchP2());
        Debug.Log("Player 2 used HighPunch.");
    }
    public void p2LowKick()
    {
        StartCoroutine(lowKickP2());
        Debug.Log("Player 2 used LowKick.");
    }
    public void p2HighKick()
    {
        StartCoroutine(highKickP2());
        Debug.Log("Player 2 used HighKick.");
    }
    public void p2Special()
    {
        StartCoroutine(specialP2());
        Debug.Log("Player 2 used Special.");
    }

    //Attacks Player 1
    public IEnumerator lowPunchP1()
    {
        yield return new WaitForSeconds(2);
        dealDamage(5, 60, player2HP,2);
    }
    public IEnumerator highPunchP1()
    {
        yield return new WaitForSeconds(3);
        dealDamage(10, 30, player2HP,2);
    }
    public IEnumerator lowKickP1()
    {
        yield return new WaitForSeconds(2);
        dealDamage(10, 30, player2HP,2);
    }
    public IEnumerator highKickP1()
    {
        yield return new WaitForSeconds(3);
        dealDamage(10, 30, player2HP,2);
    }
    public IEnumerator specialP1()
    {
        yield return new WaitForSeconds(5);
        dealDamage(10, 30, player2HP,2);
    }

    //Attacks Player 2
    public IEnumerator lowPunchP2()
    {
        yield return new WaitForSeconds(2);
        dealDamage(5, 60, player1HP,1);
    }
    public IEnumerator highPunchP2()
    {
        yield return new WaitForSeconds(3);
        dealDamage(10, 30, player1HP,1);
    }
    public IEnumerator lowKickP2()
    {
        yield return new WaitForSeconds(2);
        dealDamage(10, 30, player1HP,1);
    }
    public IEnumerator highKickP2()
    {
        yield return new WaitForSeconds(3);
        dealDamage(10, 30, player1HP,1);
    }
    public IEnumerator specialP2()
    {
        yield return new WaitForSeconds(5);
        dealDamage(10, 30, player1HP,1);
    }

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
