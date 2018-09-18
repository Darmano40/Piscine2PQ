using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket_Ball : MonoBehaviour{

    private Vector2 origTrans;
    AudioSource Basket_OK;


    void Start()
    {
        Basket_OK = GetComponent<AudioSource>();
        origTrans = transform.position;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basket_Trash")
        {
            Basket_OK.Play();
            transform.position = origTrans;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else if (collision.gameObject.tag == "Basket_Ground")
        {
            
            Basket_OK.Play();
            transform.position = origTrans;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

    }
}


