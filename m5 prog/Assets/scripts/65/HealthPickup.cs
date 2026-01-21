using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Collectable
{
    protected override void OnCollect()
    {
        Debug.Log("Health restored! +20 HP");
    }
}
