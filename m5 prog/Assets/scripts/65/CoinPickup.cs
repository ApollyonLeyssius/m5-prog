using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : Collectable
{
    protected override void OnCollect()
    {
        Debug.Log("Coin collected! +10 points");
    }
}
