using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveLeftObstacle : MonoBehaviour
{
    public float speed = 25f;
    private float leftBound = -15f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyObstacle();
    }

    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    void DestroyObstacle()
    {
        if (gameObject.CompareTag("Block") | gameObject.CompareTag("EUR") | gameObject.CompareTag("GBP") | gameObject.CompareTag("JPY") | gameObject.CompareTag("UAH") | gameObject.CompareTag("USD") && transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
