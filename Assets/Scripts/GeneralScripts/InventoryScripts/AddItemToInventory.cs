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
    [SerializeField] Sprite item2;
    public static bool slot1full = false;
    public static bool slot2full = false;
    public static bool slot3full = false;
    public static bool slot4full = false;
    public static bool slot5full = false;
    public static int maxSlot = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Add() {
        if (slot1full == false){
            slot1.sprite = item;
            slot1full = true;
        }
        else if (slot2full == false){
            slot2.sprite = item;
            slot2full = true;
        }
        else if (slot3full == false){
            slot3.sprite = item;
            slot3full = true;
        }
        else if (slot4full == false){
            slot4.sprite = item;
            slot4full = true;
        }
        else if (slot5full == false){
            slot5.sprite = item;
            slot5full = true;
        }
        Debug.Log(slot1full);
    }
    public void AddAnother() {
        if (slot1full == false){
            slot1.sprite = item2;
            slot1full = true;
        }
        else if (slot2full == false){
            slot2.sprite = item2;
            slot2full = true;
        }
        else if (slot3full == false){
            slot3.sprite = item2;
            slot3full = true;
        }
        else if (slot4full == false){
            slot4.sprite = item2;
            slot4full = true;
        }
        else if (slot5full == false){
            slot5.sprite = item2;
            slot5full = true;
        }
        Debug.Log(slot1full);
    }
}
