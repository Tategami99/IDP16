using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBambooFromInventory : MonoBehaviour
{
    [SerializeField] SpriteRenderer slot1;
    [SerializeField] SpriteRenderer slot2;
    [SerializeField] SpriteRenderer slot3;
    [SerializeField] SpriteRenderer slot4;
    [SerializeField] SpriteRenderer slot5;
    [SerializeField] Sprite blank;
    public static int coinLocation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (RemoveCoinFromInventory.bambooLocation == 1 && Panda2.bambooObtained){
            slot1.sprite = blank;
            AddItemToInventory.slot1full = false;
        }
        else if (RemoveCoinFromInventory.bambooLocation == 2 && Panda2.bambooObtained){
            slot2.sprite = blank;
            AddItemToInventory.slot2full = false;
        }
        else if (RemoveCoinFromInventory.bambooLocation == 3 && Panda2.bambooObtained){
            slot3.sprite = blank;
            AddItemToInventory.slot3full = false;
        }
        else if (RemoveCoinFromInventory.bambooLocation == 4 && Panda2.bambooObtained){
            slot4.sprite = blank;
            AddItemToInventory.slot4full = false;
        }
        else if (RemoveCoinFromInventory.bambooLocation == 5 && Panda2.bambooObtained){
            slot5.sprite = blank;
            AddItemToInventory.slot5full = false;
        }
        if (Panda2.bambooObtained){
            Panda1DialogueUI.infoObtained = true;
            Panda3.coinObtained = false;
        }
    }
}
