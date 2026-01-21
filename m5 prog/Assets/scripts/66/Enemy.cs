using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float health = 100f;
    protected float speed = 2f;

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"{gameObject.name} takes {damage} damage! HP: {health}");

        if (health <= 0)
            Die();
    }

    public virtual void Attack(GameObject target)
    {
        Debug.Log($"{gameObject.name} attacks!");
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} died!");
        Destroy(gameObject);
    }
}
