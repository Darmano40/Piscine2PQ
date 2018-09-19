using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject Pause_Buttons;

	// Use this for initialization
	void Start () {
		
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }
}

