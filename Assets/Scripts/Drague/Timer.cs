using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public int time;   //actual time
    public float t;
    public Text TimerText;    //time wrote in a text in the canvas
    private float startTime;  //strting time
    public string SceneName;

    public Image target;
    
    private int IsDone;


    void Start()
    {
        IsDone = 1;
        startTime = time;
    }
    void timeDown()
    {
        t = (startTime - Time.time) * IsDone;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        if (t >= 0f)
        {
            TimerText.text = minutes + ":" + seconds;

        }

        else
        {
            TimerText.text = "0:0.00";
            SceneManager.LoadScene(SceneName);

        }
    }
    // Update is called once per frame
    void Update()
    {
        timeDown();
        if (target.fillAmount == 0 || target.fillAmount == 1)
        {
            IsDone = 0;
        }
    }
}