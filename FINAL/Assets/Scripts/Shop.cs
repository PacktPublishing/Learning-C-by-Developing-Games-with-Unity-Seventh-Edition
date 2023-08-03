using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop<T> where T : Collectable
{
    public List<T> inventory = new List<T>();

    public void AddItem(T newItem)
    {
        inventory.Add(newItem);
    }

    public int GetStockCount<U>() where U : T
    {
        var stock = 0;

        foreach (var item in inventory)
        {
            if (item is U)
            {
                stock++;
            }
        }
        return stock;
    }
}