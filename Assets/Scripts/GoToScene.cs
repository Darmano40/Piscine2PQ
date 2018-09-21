using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            SceneManager.LoadScene("Basket");
        }	
	}
}
