using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float moveSpeed = 10;
    private float leftBound = -14;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (gameObject.CompareTag("Block") | gameObject.CompareTag("EUR") | gameObject.CompareTag("GBP") | gameObject.CompareTag("JPY") | gameObject.CompareTag("USD") | gameObject.CompareTag("UAH") && transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}

    // New way to destroy out of boundaries object

/*
private float leftEdge;

private void Start()
{
    leftEdge = Camera.main.ScreenToWorldPoint(Vector2.zero).x -  1f;
}

private void Update()
{
    if (transform.position.x < leftEdge)
    {
        Destroy(gameObject);
    }
}
*/

