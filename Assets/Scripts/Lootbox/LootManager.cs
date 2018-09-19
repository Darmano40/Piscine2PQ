using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour {
    //Permet de lire le script depuis n'importe quelle autre script Ex: LootManager.Singleton.OpenBox();
    public static LootManager Singleton;
    public List<Rarity> lootRarities;
    private int dropSum = 0;
    private int rarIdx;
    void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }
    public void OpenBox()
    {
        Debug.Log("Box ouverte !");
    }
    //Separer mais normalement dans le Open Box, Permet de selectionner un objet dans la Rareté
    public GameObject PickAnObject()
    {
        var progressDrop = lootRarities[0].rarityDropRate;
        //selection d'une raretée
        for (var i = 0; i < lootRarities.Count; i++)
        {
            dropSum += lootRarities[i].rarityDropRate;
        }
        //selection de l'item
        var rdmItem = Random.Range(0, dropSum);
        for (var j = 0; j < lootRarities.Count; j++)
        {
            if (progressDrop > rdmItem)
            {
                rarIdx = j;
                break;
            }
            else if (rdmItem >= progressDrop)
            {
                progressDrop += lootRarities[j + 1].rarityDropRate;
            }
        }
        var rdmItemInList = Random.Range(0, lootRarities[rarIdx].rarityItems.Count);
        dropSum = 0;
        return lootRarities[rarIdx].rarityItems[rdmItemInList].lootPrefab;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
