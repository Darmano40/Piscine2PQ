using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int time;
    public Text TimerText;
    private float startTime;

    // Use this for initialization
    void Start()
    {
        startTime = time;

    }

    // Update is called once per frame
    void Update()
    {
        float t = startTime - Time.time; ;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;

    }
}
 