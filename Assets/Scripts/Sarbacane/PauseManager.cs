using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject Pause_Buttons;
    public UI_MAnager my_UIM;
    public GameManager_Sarbacane my_GM;
    private Scene actualScene;
    public GameObject End_Buttons;

	// Use this for initialization
	void Start () {
        actualScene = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseGame()
    {
        Time.timeScale = 0;
        Pause_Buttons.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Pause_Buttons.SetActive(false);
    }

    public void Retry()
    {
        Time.timeScale = 1;
        my_UIM.ActualScore = 0;
        my_UIM.time = 120;
        Pause_Buttons.SetActive(false);
        End_Buttons.SetActive(false);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }
}

