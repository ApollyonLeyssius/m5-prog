using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string ItemName;
    public ItemType ItemType;
    public ItemStats Stats;
    public int SellPrice;
    public bool IsEquipped;

    // Constructor
    public Item(string name, ItemType type, ItemStats stats, int price)
    {
        ItemName = name;
        ItemType = type;
        Stats = stats;
        SellPrice = price;
        IsEquipped = false;
    }

    /// <summary>
    /// Returns a readable description of the item.
    /// </summary>
    public string Describe()
    {
        return $"{ItemName} ({ItemType})\n" +
               $"Damage: {Stats.damage}, Defense: {Stats.defense}, Weight: {Stats.weight}\n" +
               $"Sell Price: {SellPrice}";
    }

    /// <summary>
    /// Toggles equip state.
    /// </summary>
    public void ToggleEquip()
    {
        IsEquipped = !IsEquipped;
    }
}
