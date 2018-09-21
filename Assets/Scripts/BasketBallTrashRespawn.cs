using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallTrashRespawn : MonoBehaviour {

    public GameObject[] Respawners;

    public void Respawner()
    {
        int Rdm = Random.Range(0, 4);
        gameObject.transform.position = Respawners[Rdm].transform.position;
        Debug.Log(Rdm);
    }
}
