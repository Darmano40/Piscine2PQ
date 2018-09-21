using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour
{
    public GameObject Pause;


    void Start()
    {
        
    }
        
    void Update ()
    {
        
    }

    public void PauseGame()
    {
        Pause.SetActive(true);
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main_Menu");
        
    }

    public void Retry()
    {
        SceneManager.LoadScene("Drague_Thierry");

    }
}
