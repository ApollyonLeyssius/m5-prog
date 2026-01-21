using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    private float evasionChance = 0.2f;

    private void Start()
    {
        gameObject.name = "Goblin";
        health = 80f;
    }

    public override void TakeDamage(float damage)
    {
        if (Random.value < evasionChance)
        {
            Debug.Log("Goblin evades the attack!");
            return;
        }

        base.TakeDamage(damage);
    }

    public override void Attack(GameObject target)
    {
        Debug.Log("Goblin shoots an arrow at " + target.name + "!");
    }
}
