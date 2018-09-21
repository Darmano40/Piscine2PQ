using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour {

    public bool PauseActive;
    public GameObject Button;

	// Use this for initialization
	void Start () {
        PauseActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseBouton ()
    {
        if ( PauseActive = true ) {
            Time.timeScale = 0;
            Button.SetActive(true);
            PauseActive = true;
        }
            
        if ( PauseActive = false )
        {
            Time.timeScale = 1;
            Button.SetActive(false);
            PauseActive = false;
        }
        

    }
}
