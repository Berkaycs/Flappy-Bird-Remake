using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    public float speed = 10;
    private Vector2 startPos;
    private float repeatWidth;

    private void Start()
    {
        // Start where it is
        startPos = transform.position;
        // Adjust repeat part
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 5.1f;
    }
    void Update()
    {
        Move();
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

    void Move()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
