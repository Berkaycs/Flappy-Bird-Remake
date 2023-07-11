using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip lose, coin, trigger;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void playLose()
    {
        source.clip = lose;
        source.Play();
    }

    public void playCoin()
    {
        source.clip = coin;
        source.Play();
    }

    public void playTrigger()
    {
        source.clip = trigger;
        source.Play();
    }
}
