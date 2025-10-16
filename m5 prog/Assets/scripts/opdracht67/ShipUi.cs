using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShipUi : MonoBehaviour
{
    [SerializeField] private TMP_Text introductionField;
    [SerializeField] private TMP_Text messageField;

    void Start()
    {
        StartCoroutine(ShowIntroduction());
    }

    private IEnumerator ShowIntroduction()
    {
        introductionField.enabled = true;
        introductionField.text = "Welcome to Space 4 8.\nMove with WASD.\nShoot with SPACE.\nCycle with Left CTRL.\nUse with E.";
        yield return new WaitForSeconds(5f);
        introductionField.enabled = false;
    }

    public void ShowMessage(string message)
    {
        StartCoroutine(ShowTemporaryMessage(message));
    }

    private IEnumerator ShowTemporaryMessage(string message)
    {
        messageField.enabled = true;
        messageField.text = message;
        yield return new WaitForSeconds(3f);
        messageField.enabled = false;
    }
}

