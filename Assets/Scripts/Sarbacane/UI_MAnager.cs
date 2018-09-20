using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_MAnager : MonoBehaviour {

    public int time;   //actual time
    public float t;
    public Text TimerText;    //time wrote in a text in the canvas
    private float startTime;  //strting time
    public int LooseTime;

    public int ActualScore;
    public int AddScore;
    public Text score;    //displayed score
    public Outline scoreOutline; //score outline

    public Image Time_Barre;  //timer sprite

    public GameObject Endgame_Button, Timer_Button, Pause_Button;

    public GameManager_Sarbacane _my_GM;
    
    
    // Use this for initialization
    void Start () {
        startTime = time;
    }
	
	// Update is called once per frame
	void Update () {

        timeDown();
        /*
        if (Input.anyKeyDown && t >= 0f)
        {
            Scoring();
        }
        */
        timer_barre_down();
        ReSizing();
	}

    void timeDown()    
    {
        t = startTime - Time.time;

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
            Pause_Button.SetActive(false);
        }
        

    }

    public void CanScoring()
    {
        if (t >= 0f)
        {
            Scoring();
            _my_GM.DicreaseProjectiles();
        }
    }

    void Scoring()
    {
        ActualScore += AddScore;
        score.text = "" + ActualScore;
    }

    void ReSizing()
    {
        if (ActualScore < 20)
        {
            score.color = Color.black;
            score.fontSize = 95;
        }

        else if (ActualScore < 50)
        {
            score.color = Color.grey;
            score.fontSize = 110;
            scoreOutline.effectColor = Color.white;
        }

        else if (ActualScore < 70)
        {
            score.color = Color.white;
            score.fontSize = 130;
            scoreOutline.effectColor = Color.black;
        }

        else if (ActualScore < 90)
        {
            score.color = Color.blue;
            score.fontSize = 150;
            scoreOutline.effectColor = Color.cyan;
        }

        else if (ActualScore < 120)
        {
            score.color = Color.green;
            score.fontSize = 180;
            scoreOutline.effectColor = Color.yellow;
        }

        else if (ActualScore < 150)
        {
            score.color = Color.magenta;
            score.fontSize = 200;
            scoreOutline.effectColor = Color.red;
        }

        else if (ActualScore < 200)
        {
            score.color = Color.red;
            score.fontSize = 220;
            scoreOutline.effectColor = Color.black;
        }
    }

    void timer_barre_down ()
    {
        Time_Barre.fillAmount = ((startTime -Time.time) / startTime);
        //Debug.Log(Time_Barre.fillAmount);
        //Debug.Log(Time.time);

    }

    public void DicreaseTime()
    {
        startTime -= LooseTime;
    }
}
