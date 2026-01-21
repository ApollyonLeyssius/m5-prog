using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    private void Start()
    {
        gameObject.name = "Zombie";
        health = 120f;
    }

    public override void TakeDamage(float damage)
    {
        float reduced = damage * 0.8f;
        health -= reduced;

        Debug.Log($"Zombie takes {reduced} damage! HP: {health}");

        if (health <= 0)
            Die();
    }

    public override void Attack(GameObject target)
    {
        Debug.Log("Zombie bites " + target.name + "!");
    }
}
