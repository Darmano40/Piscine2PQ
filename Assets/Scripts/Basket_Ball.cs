using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Basket_Ball : MonoBehaviour {

    private Vector2 Respawn_Ball;
    public AudioClip Basket_OK;
    public AudioClip Basket_Fail;
    public GameObject img_win;
    public GameObject img_Loose;
    public AudioClip Basket_throw;
    public GameObject Direction;
    public Image Bar;
    public GameManager_Basket GameManagerBasket;
    public GameObject PausePanel;
    public Text TextTime;
    public Text TextScore;
    public Text TextBestScore;
    public BasketBallTrashRespawn TrashRespawn;

    private bool Launched;
    private float Force;
    private float ChargingUp = 0;
    private float TimerFloat;
    private float Seconds = 60;
    private int Score;

    private void Update()
    {
        TimerFloat -= Time.deltaTime;
        TextTime.text = ((Mathf.RoundToInt(TimerFloat) / 60).ToString()) + " : " + Mathf.RoundToInt(Seconds).ToString();
        Force = Bar.fillAmount * 1000;
        Bar.fillAmount += 0.01f*ChargingUp;
        Seconds -= Time.deltaTime;
        if (Seconds < 0)
        {
            Seconds = 59;
        }
        if (TimerFloat <= 0)
        {
            SceneManager.LoadScene("Basket_Score");
        }
    }


    void Start()
    {
        TimerFloat = 180.0f; 
        Launched = false;
        Respawn_Ball = transform.position;
    }

    private IEnumerator Waiting_Img()
    {

        yield return new WaitForSeconds(2f);
        img_win.SetActive(false);
        img_Loose.SetActive(false);

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
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
           // GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Launched = false;
            Score += 1;
            TextScore.text = Score.ToString();
            TextBestScore.text = Score.ToString();
            GameManagerBasket.Redo();
            TrashRespawn.Respawner();
        }
        else if (collision.gameObject.tag == "Basket_Ground")
        {
            img_Loose.SetActive(true);
            Sound_Manager_Basket.instance.RandomizeSfx(Basket_Fail);
            transform.position = Respawn_Ball;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            StartCoroutine(Waiting_Img());
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            //GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Launched = false;
            GameManagerBasket.Redo();
        }

    }
    public void Launching()
    {
        Launched = true;
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        GetComponent<Rigidbody2D>().AddForce(Direction.transform.TransformDirection(Vector2.right) * Force);
        Sound_Manager_Basket.instance.RandomizeSfx(Basket_throw);
        Bar.fillAmount = 0;
    }
    public void Charging()
    {
        ChargingUp = 1;
    }

    public void StopCharge()
    {
        ChargingUp = 0;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }

}


