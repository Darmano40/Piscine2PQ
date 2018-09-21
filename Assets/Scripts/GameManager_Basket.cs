using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Basket : MonoBehaviour {

    public GameObject Arrow;

    private Quaternion SpawnBase;
    private float TurnAmount = 0;

    private void Start()
    {
        SpawnBase = Arrow.transform.localRotation;
    }
    private void Update()
    {
        Arrow.transform.Rotate(0, 0, TurnAmount);
    }

    public void TurnUp()
    {
        TurnAmount = 0.5f;
    }

    public void StopIt()
    {
        TurnAmount = 0;
    }

    public void TurnDown()
    {
        TurnAmount = -0.5f;
    }

    public void Redo()
    {
        Arrow.transform.localRotation = SpawnBase;

    }
}
