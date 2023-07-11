using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip coin, lose, trigger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void coinSound()
    {
        source.clip = coin;
        source.Play();
    }

    public void loseSound() 
    {
        source.clip = lose;
        source.Play();
    }

    public void triggerSound()
    {
        source.clip = trigger;
        source.Play();
    }
}
