using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    public AudioSource background;

    // Start is called before the first frame update
    void Start()
    {   
        background = GameObject.Find("BackgroundAudio").GetComponent<AudioSource>();
        background.Play();
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }
}
