using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket_Ball : MonoBehaviour{

    private Vector2 origTrans;

    void Start()
    {
      
        origTrans = transform.position;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basket_Trash")
        {
            transform.position = origTrans;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        
    }
}


