using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreBoard : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private TMPro.TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        PickUp.scoreIncrease += () => score += 50;
        scoreText.text = "Score: " + score;


    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score: " + score;

    }

}
