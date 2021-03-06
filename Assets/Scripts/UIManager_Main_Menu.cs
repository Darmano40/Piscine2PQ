﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_Main_Menu : MonoBehaviour {

    public float imageSpeed, screenSpeed;
    public GameObject TextSpashscreen;

    private bool isSplashScreenOn;
    private GameObject fond, splashScreen, mainMenu;

    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Landscape;

        if (SceneManager.GetActiveScene().name == "Main_Menu")
        {
            isSplashScreenOn = true;
            fond = transform.GetChild(0).gameObject;
            splashScreen = transform.GetChild(1).gameObject;
            mainMenu = transform.GetChild(2).gameObject;
        }

    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main_Menu")
        {
            if (Input.GetMouseButtonDown(0) && isSplashScreenOn)
                isSplashScreenOn = false;
            

            if (!isSplashScreenOn)
            {
                TextSpashscreen.SetActive(false);
                mainMenu.transform.GetChild(0).GetComponent<Button>().interactable = true;
                mainMenu.transform.GetChild(1).GetComponent<Button>().interactable = true;

                if (mainMenu.GetComponent<RectTransform>().position.y < 400)
                {
                    mainMenu.GetComponent<RectTransform>().transform.Translate(Vector3.up * screenSpeed * Time.deltaTime);
                    splashScreen.GetComponent<RectTransform>().transform.Translate(Vector3.up * screenSpeed * Time.deltaTime);
                    mainMenu.transform.GetChild(0).GetComponent<Button>().interactable = false;
                    mainMenu.transform.GetChild(1).GetComponent<Button>().interactable = false;
                }

                if (fond.GetComponent<RectTransform>().position.y < 510)
                    fond.GetComponent<RectTransform>().transform.Translate(Vector3.up * imageSpeed * Time.deltaTime);
            }
        }
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
        SceneManager.LoadScene("BasketTuto");
    }

    public void LoadSarbacane()
    {
        SceneManager.LoadScene("Sarbacane_Son");
    }

    public void LoadDrague()
    {
        SceneManager.LoadScene("Drague_tuto");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
