using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem
{
    public string ItemName { get; private set; }

    protected InventoryItem(string itemName)
    {
        ItemName = itemName;
    }
}
