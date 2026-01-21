using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Singleton for easy access (common in small projects)
    public static ScoreManager Instance { get; private set; }

    private int currentScore;

    // Delegate event for score change
    public event Action<int> OnScoreChanged;

    private void Awake()
    {
        // Basic singleton setup
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    /// <summary>
    /// Adds score and notifies listeners.
    /// </summary>
    public void AddScore(int amount)
    {
        currentScore += amount;

        // Fire delegate event (loose coupling)
        OnScoreChanged?.Invoke(currentScore);
    }
}
