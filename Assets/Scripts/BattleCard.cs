using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class BattleCard
{
    int str;
    int def;
    int dmg;
    int id;

    public BattleCard()
    {
        
    }

    public BattleCard(int s, int de, int dm, int i)
    {
        str = s;
        def = de;
        dmg = dm;
        id = i;
    }

    public override string ToString()
    {
        return "str: " + str.ToString() + " def: " + def.ToString() + " dmg: " + dmg.ToString() + " id: " + id.ToString();
    }
}