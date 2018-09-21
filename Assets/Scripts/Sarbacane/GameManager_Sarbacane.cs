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
    public GameObject Aura_Cible1, Aura_Cible2, Aura_Cible3, Aura_Cible4;

    public GameObject Angry_Cible1, Angry_Cible2, Angry_Cible3, Angry_Cible4;
    public GameObject BD_Cible1, BD_Cible2, BD_Cible3, BD_Cible4;


    private int Number_Projectile_Cible1, Number_Projectile_Cible2, Number_Projectile_Cible3, Number_Projectile_Cible4;
    public UI_MAnager UI_Man;

    public int timer_cible1, timer_cible2, timer_cible3, timer_cible4;
    private float startTime_Cible1, startTime_Cible2, startTime_Cible3, startTime_Cible4;
    private float timeLeft_Cible1, timeLeft_Cible2, timeLeft_Cible3, timeLeft_Cible4;

    private bool Cible1_Returned, Cible2_Returned, Cible3_Returned, Cible4_Returned;

    public Button ShootButton;

    public int Minimum_Projectile_Range = 5, Maximum_Projectile_Range = 10;

    public Sound_Manager_Sarbacane my_SM;

    public GameObject Tuto01, Tuto02, Tuto03;
    public bool can_Shoot, tuto02_Activated, tuto03_Activated;

    // Use this for initialization
    void Start()
    {
        Number_Projectile_Cible1 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Number_Projectile_Cible2 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Number_Projectile_Cible3 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Number_Projectile_Cible4 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);

        timeLeft_Cible1 = timer_cible1 * 60;
        timeLeft_Cible2 = timer_cible2 * 60;
        timeLeft_Cible3 = timer_cible3 * 60;
        timeLeft_Cible4 = timer_cible4 * 60;
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Number_Projectile_Cible1 <= 0)
            {

            if (!tuto03_Activated)
            {
                Tuto03.SetActive(true);
                tuto03_Activated = true;
            }
            //my_SM.Repere_Cible();
            Angry_Cible1.SetActive(true);
                timeLeft_Cible1--;
                if (timeLeft_Cible1 <= 0f && !Cible1_Returned)
                {

                    UI_Man.AddBonusScore();
                    ResetNumberProjectilesCibles1();
                }
                else if (timeLeft_Cible1 >= 0f && Input.GetMouseButtonDown(0))
                {
                    Cible1_Returned = true;
                    BD_Cible1.SetActive(true);
                    UI_Man.DicreaseTime();
                    Sarbacane_East.SetActive(false);
                    timeLeft_Cible1 = -0.1f;
                    Tuto03.SetActive(false);
                }
            }
            if (Number_Projectile_Cible2 <= 0)
        {
            if (!tuto03_Activated)
            {
                Tuto03.SetActive(true);
                tuto03_Activated = true;
            }
            //my_SM.Repere_Cible();
            Angry_Cible2.SetActive(true);
                timeLeft_Cible2--;
                if (timeLeft_Cible2 <= 0f && !Cible2_Returned)
                {
                    UI_Man.AddBonusScore();
                    ResetNumberProjectilesCibles2();
                }
                else if (timeLeft_Cible2 >= 0f && Input.GetMouseButtonDown(0))
                {
                    Cible2_Returned = true;
                    BD_Cible2.SetActive(true);
                    UI_Man.DicreaseTime();
                    Sarbacane_North_East.SetActive(false);
                    timeLeft_Cible2 = -0.1f;
                    Tuto03.SetActive(false);
            }
            }
            if (Number_Projectile_Cible3 <= 0)
        {
            if (!tuto03_Activated)
            {
                Tuto03.SetActive(true);
                tuto03_Activated = true;
            }
            //my_SM.Repere_Cible();
            Angry_Cible3.SetActive(true);
                timeLeft_Cible3--;
                if (timeLeft_Cible3 <= 0f && !Cible3_Returned)
                {
                    UI_Man.AddBonusScore();
                    ResetNumberProjectilesCibles3();
                }
                else if (timeLeft_Cible3 >= 0f && Input.GetMouseButtonDown(0))
                {
                    Cible3_Returned = true;
                    BD_Cible3.SetActive(true);
                    UI_Man.DicreaseTime();
                    Sarbacane_North_West.SetActive(false);
                    timeLeft_Cible3 = -0.1f;
                    Tuto03.SetActive(false);

            }
            }
            if (Number_Projectile_Cible4 <= 0)
        {
            if (!tuto03_Activated)
            {
                Tuto03.SetActive(true);
                tuto03_Activated = true;
            }
            //my_SM.Repere_Cible();
            Angry_Cible4.SetActive(true);
                timeLeft_Cible4--;
                if (timeLeft_Cible4 <= 0f && !Cible4_Returned)
                {
                    UI_Man.AddBonusScore();
                    ResetNumberProjectilesCibles4();
                }
                else if (timeLeft_Cible4 >= 0f && Input.GetMouseButtonDown(0))
                {
                    Cible4_Returned = true;
                    BD_Cible4.SetActive(true);
                    UI_Man.DicreaseTime();
                    Sarbacane_West.SetActive(false);
                    timeLeft_Cible4 = -0.1f;
                    Tuto03.SetActive(false);
            }
            }

        if(BD_Cible1.activeSelf && BD_Cible2.activeSelf && BD_Cible3.activeSelf && BD_Cible4.activeSelf)
        {
            UI_Man.Timeout();
        }


    }


    public void Cibles1()
    {
        Sarbacane_East.SetActive(true);
        Sarbacane_West.SetActive(false);
        Sarbacane_North_East.SetActive(false);
        Sarbacane_North_West.SetActive(false);
        Aura_Cible1.SetActive(true);
        Aura_Cible2.SetActive(false);
        Aura_Cible3.SetActive(false);
        Aura_Cible4.SetActive(false);
        Tuto01.SetActive(false);
        can_Shoot = true;
        if (!tuto02_Activated)
        {
            Tuto02.SetActive(true);
            tuto02_Activated = true;
        }
    }

    public void Cibles2()
    {
        Sarbacane_East.SetActive(false);
        Sarbacane_West.SetActive(false);
        Sarbacane_North_East.SetActive(true);
        Sarbacane_North_West.SetActive(false);
        Aura_Cible1.SetActive(false);
        Aura_Cible2.SetActive(true);
        Aura_Cible3.SetActive(false);
        Aura_Cible4.SetActive(false);
        Tuto01.SetActive(false);
        can_Shoot = true;
        if (!tuto02_Activated)
        {
            Tuto02.SetActive(true);
            tuto02_Activated = true;
        }
    }

    public void Cibles3()
    {
        Sarbacane_East.SetActive(false);
        Sarbacane_West.SetActive(false);
        Sarbacane_North_East.SetActive(false);
        Sarbacane_North_West.SetActive(true);
        Aura_Cible1.SetActive(false);
        Aura_Cible2.SetActive(false);
        Aura_Cible3.SetActive(true);
        Aura_Cible4.SetActive(false);
        Tuto01.SetActive(false);
        can_Shoot = true;
        if (!tuto02_Activated)
        {
            Tuto02.SetActive(true);
            tuto02_Activated = true;
        }
    }

    public void Cibles4()
    {
        Sarbacane_East.SetActive(false);
        Sarbacane_West.SetActive(true);
        Sarbacane_North_East.SetActive(false);
        Sarbacane_North_West.SetActive(false);
        Aura_Cible1.SetActive(false);
        Aura_Cible2.SetActive(false);
        Aura_Cible3.SetActive(false);
        Aura_Cible4.SetActive(true);
        Tuto01.SetActive(false);
        can_Shoot = true;
        if (!tuto02_Activated)
        {
            Tuto02.SetActive(true);
            tuto02_Activated = true;
        }

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


    public void ResetNumberProjectilesCibles1()
    {
        
        timeLeft_Cible1 = timer_cible1 * 60;
        Angry_Cible1.SetActive(false);
        Number_Projectile_Cible1 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Debug.Log("cible1 reset: " + Number_Projectile_Cible1);
    }

    public void ResetNumberProjectilesCibles2()
    {

        timeLeft_Cible2 = timer_cible2 * 60;
        Angry_Cible2.SetActive(false);
        Number_Projectile_Cible2 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Debug.Log("cible1 reset: " + Number_Projectile_Cible2);
    }

    public void ResetNumberProjectilesCibles3()
    {

        timeLeft_Cible3 = timer_cible3 * 60;
        Angry_Cible3.SetActive(false);
        Number_Projectile_Cible3 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Debug.Log("cible1 reset: " + Number_Projectile_Cible3);
    }

    public void ResetNumberProjectilesCibles4()
    {

        timeLeft_Cible4 = timer_cible4 * 60;
        Angry_Cible4.SetActive(false);
        Number_Projectile_Cible4 = Random.Range(Minimum_Projectile_Range, Maximum_Projectile_Range);
        Debug.Log("cible1 reset: " + Number_Projectile_Cible4);
    }


}
