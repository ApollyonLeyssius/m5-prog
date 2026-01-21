using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    private void Start()
    {
        gameObject.name = "Dragon";
        health = 1000f;
    }

    public override void Attack(GameObject target)
    {
        Debug.Log("Dragon breathes fire on " + target.name + "!");
    }
}
