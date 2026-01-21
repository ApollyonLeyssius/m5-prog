using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Collectable : MonoBehaviour
{
    // Event fired when any collectable is collected
    public static event Action<Collectable> OnCollected;

    private void Awake()
    {
        // Ensure trigger collider
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if player touched it
        if (other.CompareTag("Player"))
        {
            OnCollect();

            // Notify manager (loose coupling)
            OnCollected?.Invoke(this);

            // Remove object from scene
            Destroy(gameObject);
        }
    }

    protected abstract void OnCollect();
}
