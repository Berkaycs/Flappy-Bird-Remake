using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forceSpeed = 15;
    public float forceStart = 10;
    private float topBound = 5;
    private Rigidbody2D playerRb;
    private GameManager gameManager;
    public ParticleSystem destroyParticle;
    private Audio sound;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerRb.AddForce(Vector3.up * forceStart, ForceMode2D.Impulse);
        sound = GetComponent<Audio>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        destroyParticle = GameObject.Find("Destroy").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        
        if (transform.position.y > topBound)
        {
            destroyParticle.Play();
            sound.playLose();
            Destroy(gameObject);
            Debug.Log("Top bound");
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up *  forceSpeed, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            destroyParticle.Play();
            sound.playLose();
            Destroy(gameObject);
            Debug.Log("Collided with block");
        }        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger"))  // you don't need to write .gameObject in trigger method
        {
            sound.playTrigger();
            gameManager.AddScore(1);
            Debug.Log("Trigger has happened");
        }

        if (other.gameObject.CompareTag("EUR"))
        {
            sound.playCoin();
            gameManager.AddScore(30);
            Destroy(other.gameObject);
            Debug.Log("Coin is taken");
        }
        if (other.gameObject.CompareTag("GBP"))
        {
            sound.playCoin();
            gameManager.AddScore(35);
            Destroy(other.gameObject);
            Debug.Log("Coin is taken");
        }

        if (other.gameObject.CompareTag("JPY"))
        {
            sound.playCoin();
            gameManager.AddScore(2);
            Destroy(other.gameObject);
            Debug.Log("Coin is taken");
        }

        if (other.gameObject.CompareTag("UAH"))
        {
            sound.playCoin();
            gameManager.AddScore(5);
            Destroy(other.gameObject);
            Debug.Log("Coin is taken");
        }

        if (other.gameObject.CompareTag("USD"))
        {
            sound.playCoin();
            gameManager.AddScore(25);
            Destroy(other.gameObject);
            Debug.Log("Coin is taken");
        }
    }
}
