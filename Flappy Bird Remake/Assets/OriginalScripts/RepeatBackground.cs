using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // Create variables to define background start position and where it repeates
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        // Start where it is
        startPos = transform.position;
        // Adjust repeat part
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
