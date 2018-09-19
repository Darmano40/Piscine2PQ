using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_MAnager : MonoBehaviour {

    public int time;   //actual time
    public float t;
    public Text TimerText;    //time wrote in a text in the canvas
    private float startTime;  //strting time

    public int scoreValue = 0;   //start score
    public Text score;    //displayed score
    public Outline scoreOutline; //score outline

    public Image Time_Barre;  //timer sprite

    public GameObject Endgame_Button, Timer_Button;

    // Use this for initialization
    void Start () {
        startTime = time;
    }
	
	// Update is called once per frame
	void Update () {

        timeDown();
        if (Input.anyKeyDown && t >= 0f)
        {
            Scoring();
        }
        timer_barre_down();
        ReSizing();
	}

    void timeDown()    
    {
        t = startTime - Time.time; ;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        if (t >= 0f)
        {
            TimerText.text = minutes + ":" + seconds;
            
        }

        else
        {
            Time.timeScale = 0;
            TimerText.text = "0:0";
            Endgame_Button.SetActive(true);
            Timer_Button.SetActive(false);
        }
        

    }

    void Scoring()
    {

        scoreValue += 10;
        score.text = "" + scoreValue;
    }

    void ReSizing()
    {
        if (scoreValue < 20)
        {
            score.color = Color.black;
            score.fontSize = 95;
        }

        else if (scoreValue < 50)
        {
            score.color = Color.grey;
            score.fontSize = 130;
            scoreOutline.effectColor = Color.white;
        }

        else if (scoreValue < 70)
        {
            score.color = Color.white;
            score.fontSize = 150;
            scoreOutline.effectColor = Color.black;
        }

        else if (scoreValue < 90)
        {
            score.color = Color.blue;
            score.fontSize = 180;
            scoreOutline.effectColor = Color.cyan;
        }

        else if (scoreValue < 120)
        {
            score.color = Color.green;
            score.fontSize = 210;
            scoreOutline.effectColor = Color.yellow;
        }

        else if (scoreValue < 150)
        {
            score.color = Color.magenta;
            score.fontSize = 250;
            scoreOutline.effectColor = Color.red;
        }

        else if (scoreValue < 200)
        {
            score.color = Color.red;
            score.fontSize = 290;
            scoreOutline.effectColor = Color.black;
        }
    }

    void timer_barre_down ()
    {
        Time_Barre.fillAmount = ((startTime -Time.time) / startTime);
        //Debug.Log(Time_Barre.fillAmount);
        //Debug.Log(Time.time);

    }
}
