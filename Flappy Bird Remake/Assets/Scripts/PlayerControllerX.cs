using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private GameManagerX gameManager;
    private AudioX soundEffects;
    public ParticleSystem destroyParticle;
    private ParallaxEffectX backgroundSound;

    public float speedForce = 10;
    private float topBound = 5;
    public bool gameOver = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        soundEffects = GetComponent<AudioX>();
        backgroundSound = GameObject.Find("Background").GetComponent<ParallaxEffectX>();
        destroyParticle = GameObject.Find("Destroy").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Debug.Log("Top bound is exceed");
            Destroy(gameObject);
            destroyParticle.Play();
            soundEffects.loseSound();
            backgroundSound.background.Stop();
        }

        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            playerRb.AddForce(Vector2.up * speedForce, ForceMode2D.Impulse);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block") | collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);           
            destroyParticle.Play();
            soundEffects.loseSound();
            backgroundSound.background.Stop();
            Debug.Log("Collided with the block");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trigger"))
        {
            soundEffects.triggerSound();
            Debug.Log("Trigger has happened");
            gameManager.AddScore(1);
        }

        if (collision.gameObject.CompareTag("EUR"))
        {
            soundEffects.coinSound();
            Destroy(collision.gameObject);
            Debug.Log("Coin is triggered");
            gameManager.AddScore(30);
        }

        if (collision.gameObject.CompareTag("USD"))
        {
            soundEffects.coinSound();
            Destroy(collision.gameObject);
            Debug.Log("Coin is triggered");
            gameManager.AddScore(25);
        }

        if (collision.gameObject.CompareTag("GBP"))
        {
            soundEffects.coinSound();
            Destroy(collision.gameObject);
            Debug.Log("Coin is triggered");
            gameManager.AddScore(35);
        }

        if (collision.gameObject.CompareTag("UAH"))
        {
            soundEffects.coinSound();
            Destroy(collision.gameObject);
            Debug.Log("Coin is triggered");
            gameManager.AddScore(5);
        }

        if (collision.gameObject.CompareTag("JPY"))
        {
            soundEffects.coinSound();
            Destroy(collision.gameObject);
            Debug.Log("Coin is triggered");
            gameManager.AddScore(3);
        }
    }
}
