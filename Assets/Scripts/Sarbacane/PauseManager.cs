﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject Pause_Buttons, Timer, Pause_Icon, Shoot_Button;
    public GameObject[] BD_Cibles;
    public GameObject[] Angry_Cibles;
    public UI_MAnager my_UIM;
    public GameManager_Sarbacane my_GM;
    private Scene actualScene;
    public GameObject End_Buttons;
    public bool is_Paused;

	// Use this for initialization
	void Start () {
        actualScene = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseGame()
    {
        is_Paused = true;
        Time.timeScale = 0;
        Pause_Buttons.SetActive(true);
        Shoot_Button.SetActive(false);
    }

    public void Resume()
    {
        is_Paused = false;
        Time.timeScale = 1;
        Pause_Buttons.SetActive(false);
        Shoot_Button.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale = 1;
        my_UIM.ActualScore = 0;
        my_UIM.score.text = "" + 0;
        my_UIM.time = my_UIM.startTime;
        my_UIM.t = my_UIM.time * 60;
        Pause_Buttons.SetActive(false);
        End_Buttons.SetActive(false);
        Timer.SetActive(true);
        Pause_Icon.SetActive(true);
        Shoot_Button.SetActive(true);
        my_UIM.score.color = Color.black; ;
        my_UIM.score.fontSize = 95;
        my_UIM.scoreOutline.effectColor = Color.white;
        for (int i = 0; i < BD_Cibles.Length; i++)
        {
            BD_Cibles[i].SetActive(false);
        }
        for (int i = 0; i < Angry_Cibles.Length; i++)
        {
            Debug.Log("angry_returns");
            Angry_Cibles[i].SetActive(false);
        }

    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }
}

