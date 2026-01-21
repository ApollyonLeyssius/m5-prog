using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : Enemy
{
    private float regenAmount = 5f;

    private void Start()
    {
        gameObject.name = "Troll";
        health = 150f;
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);

        // Troll regenerates after taking damage
        if (health > 0)
        {
            health += regenAmount;
            Debug.Log("Troll regenerates " + regenAmount + " HP! Current HP: " + health);
        }
    }

    public override void Attack(GameObject target)
    {
        Debug.Log("Troll smashes " + target.name + " with a club!");
    }
}
