using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Exp;

    public Character()
    {
        Reset();
    }

    public Character(string name)
    {
        this.Name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.Name, this.Exp);
    }

    private void Reset()
    {
        this.Name = "Not assigned";
        this.Exp = 0;
    }
}

public class Paladin : Character
{
    public Weapon PrimaryWeapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.PrimaryWeapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.Name, this.PrimaryWeapon.Name);
    }
}