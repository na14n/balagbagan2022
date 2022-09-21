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
        if (playerN == 2)
        {
            if (x <=accuracy)
            {
                yield return new WaitForSeconds(delayATK);
                playerHP -= damageAmount;
                player2HP = playerHP;
                Debug.Log("Player 1 dealt " + damageAmount + " damage.");
            }
            else
            {
                yield return new WaitForSeconds(delayMISS);
                Debug.Log("Player 1 attack missed. ");
            }
        }
        if (playerN == 1)
        {
            if (x <=accuracy)
            {
                yield return new WaitForSeconds(delayATK);
                playerHP -= damageAmount;
                player1HP = playerHP;
                Debug.Log("Player 2 dealt " + damageAmount + " damage.");
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
        StartCoroutine(delaySystem(3,75,player2HP,2,2,2));
        Debug.Log("Player 1 used LowPunch.");
    }

    public void p1Special()
    {
        StartCoroutine(delaySystem(25,101,player2HP,2,5,3));
        Debug.Log("Player 1 used Special.");
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
