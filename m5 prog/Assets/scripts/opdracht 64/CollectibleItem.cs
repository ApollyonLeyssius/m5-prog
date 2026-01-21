using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1;

    public int ScoreValue => scoreValue;
}