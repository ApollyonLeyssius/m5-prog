using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randScale = new Vector3(Random.Range(1.0f, 2.0f), Random.Range(1.0f, 2.0f), Random.Range(1.0f, 2.0f));
        transform.localScale = randScale;
        transform.position = RandomPosition(-10f, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float z = Random.Range(min, max);
        return new Vector3(x, z);
    }

}
