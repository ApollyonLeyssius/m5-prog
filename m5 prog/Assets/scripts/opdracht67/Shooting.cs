using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private float cooldownTime = 3f;

    private float cooldownCounter = 0f;

    void Update()
    {
        cooldownCounter += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && cooldownCounter > cooldownTime)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject laser = Instantiate(laserPrefab, transform.position, transform.rotation);
        Destroy(laser, 3f);
        cooldownCounter = 0f;
    }

    public void IncreaseFireRate(float amount)
    {
        cooldownTime = Mathf.Max(0.1f, cooldownTime - amount);
    }
}