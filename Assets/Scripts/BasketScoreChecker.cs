using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketScoreChecker : MonoBehaviour {

    public static BasketScoreChecker Singleton;
    public int ScoreTotal;

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
        DontDestroyOnLoad(gameObject);
    }
}
