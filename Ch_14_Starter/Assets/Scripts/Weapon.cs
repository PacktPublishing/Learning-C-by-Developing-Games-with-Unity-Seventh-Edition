using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", this.name, this.damage);
    }
}

[Serializable]
public class WeaponShop
{
    public List<Weapon> inventory;
}