using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Loot
{
    public string name;
    public int rarity;

    public Loot(string name, int rarity)
    {
        this.name = name;
        this.rarity = rarity;
    }
}