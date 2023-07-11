using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParallaxEffectX : MonoBehaviour
{
    public AudioSource background;

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<AudioSource>();
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
