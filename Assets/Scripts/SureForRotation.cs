using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SureForRotation : MonoBehaviour {

	void Awake () {
        DontDestroyOnLoad(gameObject);
	}

    private void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().name == "Drague_02" || SceneManager.GetActiveScene().name == "PQ")
        {
            Screen.orientation = ScreenOrientation.Portrait;
            Debug.Log("GoodScene");
            Debug.Log(Screen.orientation);
        }
        else
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
}
