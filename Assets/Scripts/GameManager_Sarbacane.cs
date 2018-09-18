using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_Sarbacane : MonoBehaviour
{

    private int Nmb_Projectile_Cible1;
    private int Nmb_Projectile_Cible2;
    private int Nmb_Projectile_Cible3;
    private int Nmb_Projectile_Cible4;

    public int Level_End;
    public static GameManager_Sarbacane Singleton;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }

    // Use this for initialization
    void Start()
    {
        Nmb_Projectile_Cible1 = Random.Range(1, 10);
        Debug.Log("Cible 1: " + Nmb_Projectile_Cible1);

        Nmb_Projectile_Cible2 = Random.Range(1, 10);
        Debug.Log("Cible 2: " + Nmb_Projectile_Cible2);

        Nmb_Projectile_Cible3 = Random.Range(1, 10);
        Debug.Log("Cible 3: " + Nmb_Projectile_Cible3);

        Nmb_Projectile_Cible4 = Random.Range(1, 10);
        Debug.Log("Cible 4: " + Nmb_Projectile_Cible4);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
