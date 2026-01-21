using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    private List<Collectable> collectables = new List<Collectable>();

    private void OnEnable()
    {
        Collectable.OnCollected += HandleCollectibleCollected;
    }

    private void OnDisable()
    {
        Collectable.OnCollected -= HandleCollectibleCollected;
    }

    private void Start()
    {
        // Find all collectibles in scene
        collectables.AddRange(FindObjectsOfType<Collectable>());

        Debug.Log("Total collectibles: " + collectables.Count);
    }

    private void HandleCollectibleCollected(Collectable collected)
    {
        collectables.Remove(collected);

        Debug.Log("Collectible collected! Remaining: " + collectables.Count);
    }
}