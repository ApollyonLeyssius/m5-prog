using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        // Subscribe once ScoreManager exists
        ScoreManager.Instance.OnScoreChanged += UpdateScoreUI;

        // Initialize display at zero
        UpdateScoreUI(0);
    }

    private void OnDestroy()
    {
        if (ScoreManager.Instance != null)
            ScoreManager.Instance.OnScoreChanged -= UpdateScoreUI;
    }

    private void UpdateScoreUI(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}
