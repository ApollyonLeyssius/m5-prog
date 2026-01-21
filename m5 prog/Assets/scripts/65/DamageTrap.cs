using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrap : Collectable
{
    protected override void OnCollect()
    {
        Debug.Log("BOOM!! Player takes 5 damage");
    }
}
