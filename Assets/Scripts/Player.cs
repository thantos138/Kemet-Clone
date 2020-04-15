using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    BattleCard[] battleCards;

    //BattleCard(str, def, dmg)
    BattleCard c1 = new BattleCard(1, 0, 3, 0);
    BattleCard c2 = new BattleCard(2, 2, 0, 1);
    BattleCard c3 = new BattleCard(2, 1, 2, 2);
    BattleCard c4 = new BattleCard(3, 1, 0, 3);
    BattleCard c5 = new BattleCard(3, 0, 2, 4);
    BattleCard c6 = new BattleCard(4, 0, 1, 5);
    Color clear = new Color(0f, 0f, 0f, 0f);

    public Sprite[] CardImages;
    
    //DICard[] diHand;

    // Start is called before the first frame update
    void Start()
    {
        battleCards = new BattleCard[6];
        ResetHand();
    }

    void ResetHand()
    {
        //BattleCard(str, def, dmg)
        battleCards[0] = c1;
        battleCards[1] = c2;
        battleCards[2] = c3;
        battleCards[3] = c4;
        battleCards[4] = c5;
        battleCards[5] = c6;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowBattleHand()
    {
        //Show player's Battle Cards
        Debug.Log("Test");
        for(int ind = 0; ind < battleCards.Length; ++ind)
        {
            if(battleCards[ind] != null)
            {
                int card = ind + 1;
                string cardNum = card.ToString();
                Debug.Log("Card " + cardNum + " : " + battleCards[ind]);
                //assign sprite to actual image if card still exists in hand
                this.transform.GetChild(ind).GetComponent<Image>().sprite = CardImages[ind];
            }
            else
            {
                //assign sprite to clear sprite because card no longer exists in hand
                this.transform.GetChild(ind).GetComponent<Image>().color = clear;
            }
        }
        ResetHand();
    }
}
