using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject Pause_Buttons, Timer, Pause_Icon, Shoot_Button;
    public UI_MAnager my_UIM;
    public GameManager_Sarbacane my_GM;
    public GameObject End_Buttons;
    public bool is_Paused;

	// Use this for initialization
	void Start () {
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
        SceneManager.LoadScene(Application.loadedLevel);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }
}

