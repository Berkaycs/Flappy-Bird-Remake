using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioX : MonoBehaviour
{
    public AudioSource source;
    public AudioClip coin, lose, trigger;

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
