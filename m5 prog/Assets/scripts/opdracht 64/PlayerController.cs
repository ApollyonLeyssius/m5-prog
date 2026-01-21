using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);
        controller.SimpleMove(move * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        CollectibleItem item = other.GetComponent<CollectibleItem>();

        if (item != null)
        {
            // Notify ScoreManager through public method
            ScoreManager.Instance.AddScore(item.ScoreValue);

            Destroy(other.gameObject);
        }
    }
}