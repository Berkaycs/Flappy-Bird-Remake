using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speedForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EUR"))
        {
            Destroy(collision);
        }

        if (collision.CompareTag("USD"))
        {
            Destroy(collision);
        }

        if (collision.CompareTag("GBP"))
        {
            Destroy(collision);
        }

        if (collision.CompareTag("UAH"))
        {
            Destroy(collision);
        }

        if (collision.CompareTag("JPY"))
        {
            Destroy(collision);
        }
    }
}
