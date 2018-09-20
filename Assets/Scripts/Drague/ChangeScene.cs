using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
public string Drague_tuto;
    // Use this for initialization
    void Start () {
		
	}
	
	public void changeScene()
    {
        SceneManager.LoadScene (Drague_tuto);
    }
}
