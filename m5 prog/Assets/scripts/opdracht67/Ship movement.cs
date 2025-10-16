using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipmovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 25f;

    void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        transform.position += transform.forward * moveSpeed * moveInput * Time.deltaTime;
    }

    private void Rotate()
    {
        float rotateInput = Input.GetAxis("Horizontal");
        transform.Rotate(transform.up * rotationSpeed * rotateInput * Time.deltaTime);
    }

    public void IncreaseMoveSpeed(float amount) => moveSpeed += amount;
    public void IncreaseRotationSpeed(float amount) => rotationSpeed += amount;
}
