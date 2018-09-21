using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventSystemReturn : MonoBehaviour {

	public void SceneLoading(string scene)
    {   
        SceneManager.LoadScene(scene);
    
    }

}
