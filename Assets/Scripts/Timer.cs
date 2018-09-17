using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timer;
    public static bool timeStarted = false;

    void Update()
    {
        if (timeStarted == true)
        {
            timer += Time.deltaTime;
        }
    }

    void OnGUI()
    {
        float minutes = Mathf.Floor(timer / 60);
        float seconds = timer % 60;

        GUI.Label(new Rect(450, 10, 250, 250), minutes + ":" + Mathf.RoundToInt(seconds));
    }
}
