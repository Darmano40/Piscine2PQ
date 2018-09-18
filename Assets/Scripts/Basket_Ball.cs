using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket_Ball : MonoBehaviour{

    private Vector2 origTrans;
    public AudioClip Basket_OK;
    public AudioClip Basket_Fail;


    void Start()
    {

        origTrans = transform.position;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basket_Trash")
        {
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_OK);
            transform.position = origTrans;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else if (collision.gameObject.tag == "Basket_Ground")
        {
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_Fail);
            transform.position = origTrans;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

    }
}


