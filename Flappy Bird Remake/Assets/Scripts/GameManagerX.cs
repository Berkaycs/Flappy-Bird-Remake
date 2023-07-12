using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerX : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pointText;
    public int score;
    private int value = 0;

    // Start is called before the first frame updateq
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        score = 0;
        scoreText.text = "Score: " + score;
        pointText.text = score + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
        pointText.text = score + " POINTS";

    }
}
