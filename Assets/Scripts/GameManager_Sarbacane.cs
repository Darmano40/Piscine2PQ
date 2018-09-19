using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager_Sarbacane : MonoBehaviour
{
    public GameObject Sarbacane_West;
    public GameObject Sarbacane_North_West;
    public GameObject Sarbacane_North_East;
    public GameObject Sarbacane_East;

    public GameObject Angry_Cible1, Angry_Cible2, Angry_Cible3, Angry_Cible4;

    private int Number_Projectile_Cible1, Number_Projectile_Cible2, Number_Projectile_Cible3, Number_Projectile_Cible4;
    public UI_MAnager UI_Man;

    public int startTime_Cible1, startTime_Cible2, startTime_Cible3, startTime_Cible4;
    private float timeLeft_Cible1, timeLeft_Cible2, timeLeft_Cible3, timeLeft_Cible4;

    // Use this for initialization
    void Start()
    {
        Number_Projectile_Cible1 = Random.Range(5, 10);
        Number_Projectile_Cible2 = Random.Range(5, 10);
        Number_Projectile_Cible3 = Random.Range(5, 10);
        Number_Projectile_Cible4 = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Sarbacane_East.activeSelf || Sarbacane_North_East.activeSelf || Sarbacane_North_West.activeSelf || Sarbacane_West.activeSelf)
        {
            UI_Man.CanScoring();
        }

        if (Number_Projectile_Cible1 <= 0)
        {
            Angry_Cible1.SetActive(true);
            /*
            timeLeft_Cible1 = startTime_Cible1 - Time.time;
            if(timeLeft_Cible1 <= 0)
            {
                Angry_Cible1.SetActive(false);
            }
            else if(timeLeft_Cible1 >= 0 && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Cible 1 en colère");
                // Afficher bulle de dialogue
            }
            */
        }
        if (Number_Projectile_Cible2 <= 0)
        {
            Angry_Cible2.SetActive(true);
        }
        if (Number_Projectile_Cible3 <= 0)
        {
            Angry_Cible3.SetActive(true);
        }
        if (Number_Projectile_Cible4 <= 0)
        {
            Angry_Cible4.SetActive(true);
        }


    }

    public void Cibles1()
    {
        Sarbacane_East.SetActive(true);
        Sarbacane_West.SetActive(false);
        Sarbacane_North_East.SetActive(false);
        Sarbacane_North_West.SetActive(false);


    }

    public void Cibles2()
    {
        Sarbacane_East.SetActive(false);
        Sarbacane_West.SetActive(false);
        Sarbacane_North_East.SetActive(true);
        Sarbacane_North_West.SetActive(false);
    }

    public void Cibles3()
    {
        Sarbacane_East.SetActive(false);
        Sarbacane_West.SetActive(false);
        Sarbacane_North_East.SetActive(false);
        Sarbacane_North_West.SetActive(true);
    }

    public void Cibles4()
    {
        Sarbacane_East.SetActive(false);
        Sarbacane_West.SetActive(true);
        Sarbacane_North_East.SetActive(false);
        Sarbacane_North_West.SetActive(false);

    }


    public void DicreaseProjectiles()
    {
        if (Sarbacane_East.activeSelf)
        {
            Number_Projectile_Cible1--;
            Debug.Log("cible1: " + Number_Projectile_Cible1);
        }

        if (Sarbacane_North_East.activeSelf)
        {
            Number_Projectile_Cible2--;
            Debug.Log("cible2: " + Number_Projectile_Cible2);
        }

        if (Sarbacane_North_West.activeSelf)
        {
            Number_Projectile_Cible3--;
            Debug.Log("cible3: " + Number_Projectile_Cible3);
        }

        if (Sarbacane_West.activeSelf)
        {
            Number_Projectile_Cible4--;
            Debug.Log("cible4: " + Number_Projectile_Cible4);
        }
    }


}
