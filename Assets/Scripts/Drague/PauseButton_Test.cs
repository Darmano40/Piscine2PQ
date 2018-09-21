using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton_Test : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject Button;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume ()
    {
        Button.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        Button.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}