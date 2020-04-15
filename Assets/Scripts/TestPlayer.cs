using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    BattleCard[] battleCards;
    //DICard[] diHand;

    public Hand()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetHand();
    }

    void ResetHand()
    {
        //BattleCard(str, def, dmg)
        battleCards = new BattleCard[6];
        BattleCard c1 = new BattleCard(1, 0, 3);
        BattleCard c2 = new BattleCard(2, 2, 0);
        BattleCard c3 = new BattleCard(2, 0, 2);
        BattleCard c4 = new BattleCard(3, 1, 0);
        BattleCard c5 = new BattleCard(3, 0, 2);
        BattleCard c6 = new BattleCard(4, 0, 1);
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

    /*
    public void ShowBattleCards()
    {
        //Show player's Battle Cards
        for(int ind = 0; ind < battleCards.Length; ++ind)
        {
            int card = ind + 1;
            string cardNum = card.ToString();
            System.Console.WriteLine("Card " + cardNum + " : " + battleCards[ind].ToString());
        }
    }
    */
}
