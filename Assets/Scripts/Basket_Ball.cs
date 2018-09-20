using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket_Ball : MonoBehaviour {

    private Vector2 Respawn_Ball;
    public AudioClip Basket_OK;
    public AudioClip Basket_Fail;
    public GameObject img_win;
    public GameObject img_Loose;
    public AudioClip Basket_throw;
    public bool Launched;




    void Start()
    {
        Launched = false;

        Respawn_Ball = transform.position;

    }
    private IEnumerator Waiting_Img()
    {

        yield return new WaitForSeconds(4f);
        img_win.SetActive(false);
        img_Loose.SetActive(false);

    }

    private void FixedUpdate()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began && Launched == false) {
            Launched = true;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_throw);
            

        }
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Basket_Trash")
        {
            img_win.SetActive(true);
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_OK);
            transform.position = Respawn_Ball;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            StartCoroutine(Waiting_Img());
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            Launched = false;


        }
        else if (collision.gameObject.tag == "Basket_Ground")
        {
            img_Loose.SetActive(true);
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_Fail);
            transform.position = Respawn_Ball;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            StartCoroutine(Waiting_Img());
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            Launched = false;
        }

    }


}


