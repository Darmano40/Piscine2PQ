using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UiManager : MonoBehaviour
{
    public GameObject Pause;
    public Image LoveBarre;
    public GameObject Victory;
    public GameObject BP;
    public GameObject BU;
    public bool PaoseouPas = false;


    void Start()
    {
        LoveBarre.fillAmount = 0.1f;
    }
        
    void Update ()
    {
        Victoire();
    }

    public void Victoire()
    {
        if (LoveBarre.fillAmount >= 1f)
        {
            Victory.SetActive(true);
        }

    }
    

    public void Love()
    {
        if (PaoseouPas == false)
        { 
        LoveBarre.fillAmount += 0.1f;
        Debug.Log(LoveBarre.fillAmount);
        }
    }
    

    public void PauseGame()
    {
        Pause.SetActive(true);
        BP.SetActive(false);
        BU.SetActive(true);
        PaoseouPas = true;
    }

    public void ResumeGame()
    {
        Pause.SetActive(false);
        BP.SetActive(true);
        BU.SetActive(false);
        PaoseouPas = false;

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
