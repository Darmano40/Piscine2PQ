using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_Sarbacane : MonoBehaviour {
    public int Return;
    public int Level_End;
    public UIManager UIManager_Sarbacane;
    public SoundManager SoundManager_Sarbacane;

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
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
