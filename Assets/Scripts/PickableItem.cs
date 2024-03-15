using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem item; 
    private SpriteRenderer spriteRenderer; 

    void Awake()
    {
       spriteRenderer = GetComponent<SpriteRenderer>(); 
    }
    
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        InventoryManager.instance.AddItem(item);
        Destroy(this.gameObject);
    }
}
