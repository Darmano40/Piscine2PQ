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
            if (isSplashScreenOn)
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

    private void LoadMiniGameSelection()
    {
        SceneManager.LoadScene("Select_Level");
    }

    private void LoadExit()
    {
        Debug.Log("You quit !");
        Application.Quit();
    }

    private void LoadPQ()
    {
        SceneManager.LoadScene("PQ");
    }

    private void LoadBasket()
    {
        SceneManager.LoadScene("Basket");
    }

    private void LoadSarbacane()
    {
        SceneManager.LoadScene("Sarbacane");
    }

    private void LoadDrague()
    {
        SceneManager.LoadScene("Drague");
    }
}
