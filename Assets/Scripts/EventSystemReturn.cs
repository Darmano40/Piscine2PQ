using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventSystemReturn : MonoBehaviour {

	public void SceneLoading(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
