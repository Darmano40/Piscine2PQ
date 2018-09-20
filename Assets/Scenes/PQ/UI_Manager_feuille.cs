using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager_feuille : MonoBehaviour {

    public Image leaf;
    public float draggedleaf = 0.2f;
    public float leafState = 0.0f;
    public float filledLeaf = 1.0f;

	void Start ()
    {
        RollOnce();
    }
	
	void Update ()
    {
        if (Input.GetKeyDown("z"))
        {
            RollOnce();
        }
	}

    public void RollOnce()
    {
        leafState += draggedleaf;
        if (EntireLeaf())
        {
           // Décrocher la feuille avec "tear"
        }
        UpdateLeafDisplay();
    }

    public bool EntireLeaf()
    {
        return (leafState >= filledLeaf);
    }

    public void UpdateLeafDisplay()
    {
        leaf.fillAmount = leafState;
        Debug.Log("Sprite Updated");
    }
}


