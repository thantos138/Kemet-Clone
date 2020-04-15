using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class BattleCard
{
    int str;
    int def;
    int dmg;

    public BattleCard()
    {
        
    }

    public BattleCard(int s, int de, int dm)
    {
        str = s;
        def = de;
        dmg = dm;
    }

    public override string ToString()
    {
        return "str: " + str.ToString() + " def: " + def.ToString() + " dmg: " + dmg.ToString();
    }
}

/*
 public class Cards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
