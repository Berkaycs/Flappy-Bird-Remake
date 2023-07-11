using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftBackground : MonoBehaviour
{
    public float speed = 25f;

    private void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
