using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager_feuille : MonoBehaviour
{

    public Image roll;
    public Image leaf;

    public float draggedleaf = 0.2f;
    public float leafState = 0.2f;
    public float filledLeaf = 1.2f;

    public float tearedLeaves = 1.0f;
    public float totalLeavesPerRoll = 30.0f;

	void Start ()
    {
        UpdateLeafDisplay();
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
            tearedLeaves++;
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
        Debug.Log("Leaf Sprite Updated");
    }

    public void UpdateRollDisplay(int tearedLeaves)
    {
        roll.fillAmount = (totalLeavesPerRoll * 1.0f) / (tearedLeaves * 1.0f);
        Debug.Log("Roll Sprite Updated");
    }

}


