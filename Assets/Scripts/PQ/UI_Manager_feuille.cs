using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager_feuille : MonoBehaviour
{

    public Image roll;
    public Image leaf;

    public GameObject Score;
    public GameObject Exit_Button;
    public GameObject BG_voice_intensity;
    public GameObject Feuille_Decrochee;

    public float leafReset = 0.0f;
    public float draggedleaf = 0.2f;
    public float leafState = 0.2f;
    public float filledLeaf = 1.2f;
    public float tearedLeaves = 1.0f;
    public float totalLeavesPerRoll = 18.0f;

	void Start ()
    {
        UpdateLeafDisplay();
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Commander pour défilement feuille
        
        {
            RollOnce();
            Feuille_Decrochee.transform.Translate(0.0f, -6.0f, 0.0f);
        }

        if (leafReset >= 1.6f)
        {
            Feuille_Decrochee.SetActive(false);
        }
    }

    public void RollOnce()
    {
        leafReset += draggedleaf;
        leafState += draggedleaf;
        if (leafState >= filledLeaf)
        {
            // Décrocher la feuille avec "tear"
            tearedLeaves++;
            leafState = 0.0f;
            if (tearedLeaves == totalLeavesPerRoll)
            {
                Score.SetActive(true);
                Exit_Button.SetActive(false);
                BG_voice_intensity.SetActive(false);
            }
        }
        UpdateLeafDisplay();
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


