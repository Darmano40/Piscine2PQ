using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUpAsButton()
    {
        Instantiate(LootManager.Singleton.PickAnObject(),transform.position, transform.rotation);
        LootManager.Singleton.OpenBox();
        LootManager.Singleton.PickAnObject();
    }


}
