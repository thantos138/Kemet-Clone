using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using Player;
    //imports BattleCard


public class ShowBattleCards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCards()
    {
        BattleCard b = new BattleCard(1, 2, 3);
        Debug.Log("Test Card: " + b);

        //Show player's Battle Cards
        /*
        for(int ind = 0; ind < h.battleCards.length(); ++ind)
        {
            string cardNum = ind + 1;
            Debug.Log("Card " + cardNum + " : " + h.battleCards[ind].ToString());
        }
        */
    }
}

