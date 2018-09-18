using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager_Main_Menu : MonoBehaviour {

    public float imageSpeed, screenSpeed;

    private bool isSplashScreenOn;
    private Transform fond, splashScreen, mainMenu;

    private void Awake()
    {
        isSplashScreenOn = true;
        fond = transform.GetChild(0);
        splashScreen = transform.GetChild(1);
        mainMenu = transform.GetChild(2);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isSplashScreenOn && SceneManager.GetActiveScene().name == "Main_Menu")
            {
                isSplashScreenOn = false;
                MoveToMainMenu();
            }
        }
    }

    private void MoveToMainMenu()
    {
        /*
        fond.Translate(Vector3.up * imageSpeed * Time.deltaTime, Camera.main.transform);
        splashScreen.Translate(Vector3.up * screenSpeed * Time.deltaTime, Camera.main.transform);
        mainMenu.Translate(Vector3.up * screenSpeed * Time.deltaTime, Camera.main.transform);
        */

        splashScreen.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

    public void LoadMiniGameSelection()
    {
        SceneManager.LoadScene("Level_Selection");
    }

    public void LoadExit()
    {
        Debug.Log("You quit !");
        Application.Quit();
    }

    public void LoadPQ()
    {
        SceneManager.LoadScene("PQ");
    }

    public void LoadBasket()
    {
        SceneManager.LoadScene("Basket");
    }

    public void LoadSarbacane()
    {
        SceneManager.LoadScene("Sarbacane");
    }

    public void LoadDrague()
    {
        SceneManager.LoadScene("Drague");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
