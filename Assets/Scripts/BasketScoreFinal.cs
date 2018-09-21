using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketScoreFinal : MonoBehaviour {

    private void Start()
    {
        GetComponent<Text>().text = BasketScoreChecker.Singleton.ScoreTotal.ToString();
    }
}
