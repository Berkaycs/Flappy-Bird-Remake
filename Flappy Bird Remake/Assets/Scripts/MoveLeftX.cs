using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float moveSpeed = 10;
    private float leftBound = -14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (gameObject.CompareTag("Block") | gameObject.CompareTag("EUR") | gameObject.CompareTag("GBP") | gameObject.CompareTag("JPY") | gameObject.CompareTag("USD") | gameObject.CompareTag("UAH") && transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
