using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemToInventory : MonoBehaviour
{
    [SerializeField] SpriteRenderer slot1;
    [SerializeField] SpriteRenderer slot2;
    [SerializeField] SpriteRenderer slot3;
    [SerializeField] SpriteRenderer slot4;
    [SerializeField] SpriteRenderer slot5;
    [SerializeField] Sprite item;
    [SerializeField] GameObject self;
    public static int slotfull = 0;
    public static int maxSlot = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (slotfull == 0){
            slot1.sprite = item;
        }
        else if (slotfull == 1){
            slot2.sprite = item;
        }
        else if (slotfull == 2){
            slot3.sprite = item;
        }
        else if (slotfull == 3){
            slot4.sprite = item;
        }
        else if (slotfull == 4){
            slot5.sprite = item;
        }
        if (slotfull < maxSlot - 1){
            slotfull += 1;
            self.SetActive(false);
        }
    }
}
