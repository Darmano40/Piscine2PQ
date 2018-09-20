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
        if ((SceneManager.GetActiveScene().buildIndex >=3 && SceneManager.GetActiveScene().buildIndex <= 5) || (SceneManager.GetActiveScene().buildIndex >= 7 && SceneManager.GetActiveScene().buildIndex <= 8))
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
}
