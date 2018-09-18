using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager Singleton;

    private AudioSource AudioSource;

    public AudioClip GirlHappy;
    public AudioClip GirlUnhappy;
    public AudioClip HappyEnd;
    public AudioClip BadEnd;
    public AudioClip BadSounds;
    public AudioClip GoodSound;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }

  void Start()
    {
        AudioSource = GetComponent<AudioSource>();

    }

    public void BadSound()
    {
        AudioSource.clip = BadSounds;
        AudioSource.Play();
    }
}
