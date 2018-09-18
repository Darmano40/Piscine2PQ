using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_MAnager : MonoBehaviour {

    public int time;   //actual time
    public Text TimerText;    //time wrote in a text in the canvas
    private float startTime;  //strting time

    public int scoreValue = 0;   //start score
    public Text score;    //displayed score

    public Image Time_Barre;  //timer sprite

    // Use this for initialization
    void Start () {
        startTime = time;
    }
	
	// Update is called once per frame
	void Update () {

        timeDown();
        if (Input.anyKeyDown)
        {
            Scoring();
        }
        timer_barre_down();
	}

    void timeDown()    
    {
        float t = startTime - Time.time; ;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        if (time <= 0)
        {

        }
        TimerText.text = minutes + ":" + seconds;

    }

    void Scoring()
    {

        scoreValue += 10;
        score.text = "Score " + scoreValue;
    }

    void timer_barre_down ()
    {
        Time_Barre.fillAmount = ((startTime -Time.time) / startTime);
        Debug.Log(Time_Barre.fillAmount);
        //Debug.Log(Time.time);

    }
}
