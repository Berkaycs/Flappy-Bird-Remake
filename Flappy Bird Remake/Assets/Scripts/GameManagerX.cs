using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerX : MonoBehaviour
{
    private PlayerControllerX playerController;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI highscore;


    public int score;
    private int value = 0;

    // Pause screen
    public GameObject pauseScreen;
    private bool paused = false;

    private ParallaxEffectX backgroundSound;

    // Timer
    public TextMeshProUGUI timer;
    public TextMeshProUGUI aliveText;
    private float time;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerX>();
        backgroundSound = GameObject.Find("Background").GetComponent<ParallaxEffectX>();
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        timer = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();

        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        score = 0;
        scoreText.text = "Score: " + score;
        pointText.text = score + " POINTS";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CheckForPause();
        }

        time += Time.deltaTime;
        DisplayTime(time);
    }
    // Adjusting Score and HighScore
    public void AddScore(int value)
    {
        score += value;
        //scoreText.text = score.ToString();
        scoreText.text = "Score: " + score;
        pointText.text = score + " POINTS";

        /*
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highscore.text = "HighScore: " + score;  //.ToString();
        }
        */
        HighScore();
    }
    public void HighScore() 
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highscore.text = "HighScore: " + score;
        }
    }
    // Reset HighScore
    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highscore.text = "HighScore: " + 0;
    }

    // Pause screen
    private void CheckForPause()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
            backgroundSound.background.Stop();
        }

        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
            backgroundSound.background.Play();
        }
    }
    // Timer
    void DisplayTime(float timeToDisplay)
    {
        if (playerController.isGameOver == false)
        {
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timer.text = "Timer: " + string.Format("{0:00}:{1:00}", minutes, seconds);
            aliveText.text = "You survived: " + time;
        }
        else
        {
            playerController.isGameOver = true;
        }
    }
}
