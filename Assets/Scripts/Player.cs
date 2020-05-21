using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    BattleCard[] battleCards;
    BattleCard[] resetBattleCards;
    // int ankh;

    //BattleCard(str, def, dmg)
    BattleCard c0 = new BattleCard(1, 0, 3, 0);
    BattleCard c1 = new BattleCard(2, 2, 0, 1);
    BattleCard c2 = new BattleCard(2, 1, 2, 2);
    BattleCard c3 = new BattleCard(3, 1, 0, 3);
    BattleCard c4 = new BattleCard(3, 0, 2, 4);
    BattleCard c5 = new BattleCard(4, 0, 1, 5);
    BattleCard c6 = new BattleCard(3, 0, 3, 6);
    BattleCard c7 = new BattleCard(3, 3, 0, 7);
    Color clear = new Color(0f, 0f, 0f, 0f);
    Color white = new Color(1f, 1f, 1f, 1f);

    public Sprite[] CardImages;
    
    //DICard[] diHand;

    // Start is called before the first frame update
    void Start()
    {
        battleCards = new BattleCard[6];
        resetBattleCards = new BattleCard[6];
        resetBattleCards[0] = c0;
        resetBattleCards[1] = c1;
        resetBattleCards[2] = c2;
        resetBattleCards[3] = c3;
        resetBattleCards[4] = c4;
        resetBattleCards[5] = c5;
        ResetHand();
    }

    void ResetHand()
    {
        //BattleCard(str, def, dmg)
        for(int ind = 0; ind < battleCards.Length; ++ind)
        {
            battleCards[ind] = resetBattleCards[ind];
        }
    }

    public void ShowBattleHand()
    {
        //Show player's Battle Cards
        for(int ind = 0; ind < battleCards.Length; ++ind)
        {
            if(battleCards[ind] != null)
            {
                int card = ind + 1;
                string cardNum = card.ToString();
                Debug.Log("Card " + cardNum + " : " + battleCards[ind]);
                //assign sprite to actual image if card still exists in hand
                this.transform.GetChild(ind).GetComponent<Image>().color = white;
                this.transform.GetChild(ind).GetComponent<Image>().sprite = CardImages[battleCards[ind].id];
            }
            else
            {
                //assign sprite to clear sprite because card no longer exists in hand
                this.transform.GetChild(ind).GetComponent<Image>().color = clear;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
