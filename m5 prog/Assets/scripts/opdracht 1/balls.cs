using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;
    public Material mat;
    private void CreateBall()
    {
        Instantiate(prefab);
    }

    private void CreateBall(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(prefab);
        Material material = ball.GetComponent<MeshRenderer>().material;

        // voor CORE pipeline
        mat.SetColor("_Color", c);

        //Voor URP
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            CreateBall(color, randPos);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Vector3 randPos = RandomPosition(-10f, 10f);
            CreateBall(randColor, randPos);

            elapsedTime = 0f;
        }
    }

    Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        return new Color(r, g, b, 1f);
    }
    Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);
        return new Vector3(x, y, z);
    }
    void DestroyBall(GameObject ball)
    {
        Destroy(ball, 5f);
    }
}

