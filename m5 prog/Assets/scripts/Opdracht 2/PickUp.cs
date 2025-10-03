using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public static event Action scoreIncrease;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreIncrease?.Invoke();
            Debug.Log("Picked up " + gameObject.name);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
