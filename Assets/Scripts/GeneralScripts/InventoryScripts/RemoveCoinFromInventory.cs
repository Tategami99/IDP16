using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCoinFromInventory : MonoBehaviour
{
    [SerializeField] SpriteRenderer slot1;
    [SerializeField] SpriteRenderer slot2;
    [SerializeField] SpriteRenderer slot3;
    [SerializeField] SpriteRenderer slot4;
    [SerializeField] SpriteRenderer slot5;
    [SerializeField] Sprite bamboo;
    public static int bambooLocation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (RemoveSwordFromInventory.coinLocation == 1 && Panda3.coinObtained){
            slot1.sprite = bamboo;
            AddItemToInventory.slot1full = true;
            bambooLocation = 1;
        }
        else if (RemoveSwordFromInventory.coinLocation == 2 && Panda3.coinObtained){
            slot2.sprite = bamboo;
            AddItemToInventory.slot2full = true;
            bambooLocation = 2;
        }
        else if (RemoveSwordFromInventory.coinLocation == 3 && Panda3.coinObtained){
            slot3.sprite = bamboo;
            AddItemToInventory.slot3full = true;
            bambooLocation = 3;
        }
        else if (RemoveSwordFromInventory.coinLocation == 4 && Panda3.coinObtained){
            slot4.sprite = bamboo;
            AddItemToInventory.slot4full = true;
            bambooLocation = 4;
        }
        else if (RemoveSwordFromInventory.coinLocation == 5 && Panda3.coinObtained){
            slot5.sprite = bamboo;
            AddItemToInventory.slot5full = true;
            bambooLocation = 5;
        }
        if (Panda3.coinObtained){
            Panda2.bambooObtained = true;
            Panda3.coinObtained = false;
        }
    }
}