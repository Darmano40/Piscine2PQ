using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Manager : MonoBehaviour {
    public Image ExpImage;
    public Text ExpText;
    public Text LevelText;
    public int AddedExpPerLevel = 250;

    private int PlayerLvl = 1;
    private int PlayerExp = 0;
	// Use this for initialization
	void Start () {
        UpdateExpDisplay();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddExp(int ExpAmount)
    {
        PlayerExp += ExpAmount;
        while (AmLevelUp())
        {
            LevelUpPls();
        }
        UpdateExpDisplay();
    }

    public void UpdateExpDisplay()
    {
        ExpText.text = PlayerExp.ToString() + "/ " + AddedExpPerLevel.ToString();
        LevelText.text = PlayerLvl.ToString();
        ExpImage.fillAmount = (PlayerExp * 1.0f) / (AddedExpPerLevel + 1.0f);
    }

    public bool AmLevelUp()
    {
        return (PlayerExp >= AddedExpPerLevel);
    }

    public void LevelUpPls()
    {
        var TooMuchExp = PlayerExp % AddedExpPerLevel;
        AddedExpPerLevel += 250;
        PlayerExp = TooMuchExp;
        PlayerLvl++;
    }
}
