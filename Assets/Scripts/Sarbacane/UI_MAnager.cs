using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_MAnager : MonoBehaviour {

    public float time;   //actual time
    public float t;
    public Text TimerText;    //time wrote in a text in the canvas
    public float startTime;  //strting time
    public float LooseTime;

    public int ActualScore;
    public int AddScore;
    public Text score;    //displayed score
    public Outline scoreOutline; //score outline
    public int BonusScore;

    public Image Time_Barre;  //timer sprite

    public GameObject Endgame_Button, Timer_Button, Pause_Button;

    public GameManager_Sarbacane _my_GM;

    public Sound_Manager_Sarbacane my_SM;

    public PauseManager my_PM;
    
    
    // Use this for initialization
    void Start () {
        //startTime = time;
        t = time * 60;
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

        //t = startTime - Time.time;
        t--;
        string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60).ToString("f0");
        if (t >= 0f)
        {
            TimerText.text = minutes; //+ ":" + seconds;
        }

        if (t == 0f)
        {
            Timeout();
        }
        

    }

    public void CanScoring()
    {
        if(_my_GM.Sarbacane_East.activeSelf || _my_GM.Sarbacane_North_East.activeSelf || _my_GM.Sarbacane_North_West.activeSelf || _my_GM.Sarbacane_West.activeSelf)
        if (t >= 0f)
        {
            my_SM.Impact_Cible();
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
        Time_Barre.fillAmount = ((t / 60) /time);
        //Debug.Log(Time_Barre.fillAmount);
        //Debug.Log(Time.time);

    }

    public void DicreaseTime()
    {
        startTime -= LooseTime;
        Debug.Log("decrease time");
    }

    public void AddBonusScore()
    {
        my_SM.Bonus_Sarbacane();
        ActualScore += BonusScore;
    }

    public void Timeout()
    {
        my_SM.TimeOut_Sarbacane();
        Time.timeScale = 0;
        TimerText.text = "0:0";
        Endgame_Button.SetActive(true);
        Timer_Button.SetActive(false);
        Pause_Button.SetActive(false);
        t = 0;
    }
}
