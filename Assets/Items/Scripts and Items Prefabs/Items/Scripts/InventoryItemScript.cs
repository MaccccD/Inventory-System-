using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class InventoryItemScript 
{
    public ItemsObjects Items;

    public InventoryItemScript(ItemsObjects items )
    {
        Items = items;
    }
}
 