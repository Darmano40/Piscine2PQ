using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager_feuille : MonoBehaviour
{

    public Image jauge;
    public Image leaf;

    public GameObject Score;
    public GameObject Exit_Button;
    public GameObject BG_voice_intensity;
    public GameObject Feuille_Decrochee;

    public float leafReset = 0.0f;
    public float draggedleaf = 0.2f;
    public float leafState = 0.2f;
    public float filledLeaf = 1.2f;
    public int tearedLeaves = 0;
    public float totalLeavesPerRoll = 18.0f;

    public float jaugePQ;

	void Start ()
    {
        jaugePQ = tearedLeaves / totalLeavesPerRoll;
        Debug.Log(jaugePQ);
        UpdateLeafDisplay();
        UpdateJaugeDisplay(tearedLeaves);
    }
	
	void Update ()
    {
        jaugePQ = tearedLeaves / totalLeavesPerRoll;
        if (Input.GetKeyDown(KeyCode.Mouse0)) // Commander pour défilement feuille
        
        {
            RollOnce();
            Feuille_Decrochee.transform.Translate(0.0f, -6.0f, 0.0f);
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
        UpdateJaugeDisplay(tearedLeaves);
    }

    public void UpdateLeafDisplay()
    {
        leaf.fillAmount = leafState;
        Debug.Log("Leaf Sprite Updated");
    }

    public void UpdateJaugeDisplay(int tearedLeaves)
    {
        jauge.fillAmount = jaugePQ;
        Debug.Log("Jauge Sprite Updated");
    }

}


