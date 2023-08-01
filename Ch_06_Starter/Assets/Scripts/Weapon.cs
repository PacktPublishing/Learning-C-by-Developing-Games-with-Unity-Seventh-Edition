using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    public string Name;
    public int Damage;

    public Weapon(string name, int damage)
    {
        this.Name = name;
        this.Damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", this.Name, this.Damage);
    }
}