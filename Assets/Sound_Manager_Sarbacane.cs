using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Manager_Sarbacane : MonoBehaviour
{

    public static Sound_Manager_Sarbacane Singleton;

    private AudioSource AudioSource;

    public AudioClip Repere;
    public AudioClip Projectile;
    public AudioClip Impact;
    public AudioClip TimeOut;
    public AudioClip Bonus;
    

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

    public void Repere_Cible()
    {
        AudioSource.clip = Repere;
        AudioSource.Play();
    }

    public void Impact_Cible()
    {
        AudioSource.clip = Impact;
        AudioSource.Play();
    }

    public void Projectile_Sarbacane()
    {
        AudioSource.clip = Projectile;
        AudioSource.Play();
    }

    public void Bonus_Sarbacane()
    {
        AudioSource.clip = Bonus;
        AudioSource.Play();
    }

    public void TimeOut_Sarbacane()
    {
        AudioSource.clip = TimeOut;
        AudioSource.Play();
    }
}

