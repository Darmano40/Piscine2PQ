using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =  "LootItem_", menuName = "New Loot Item")]
public class LootItem : ScriptableObject {
    public string lootName;
    public GameObject lootPrefab;
    public enum Types
    {
        AddTime, AddError
    }
    public Types lootType;
}
