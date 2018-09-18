using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket_Ball : MonoBehaviour{

    private Vector2 Respawn_Ball;
    public AudioClip Basket_OK;
    public AudioClip Basket_Fail;
    public GameObject img_win;
    public GameObject img_Loose;



    void Start()
    {

        Respawn_Ball = transform.position;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basket_Trash")
        {
            img_win.SetActive(true);
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_OK);
            transform.position = Respawn_Ball;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                

        }
        else if (collision.gameObject.tag == "Basket_Ground")
        {
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_Fail);
            transform.position = Respawn_Ball;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

    }
}


