using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites; 

    void Awake()
    {
        instance = this; 
    }

    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item; 
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;
            }
        }
    }
}
