using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vigicle : MonoBehaviour
{
    private bool stopped = false;
    protected float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Accelerate()
    { 
        Debug.Log("The vehicle is accelerating");
    }

    float UseFuel(float amount)
    {
        speed =- amount;
        return amount;
        if (speed < 0)
        {
            speed = 0;
        }
    }

    private void OnParticleSystemStopped()
    {
        Debug.Log("The vehicle has stopped");
    }
}
}
