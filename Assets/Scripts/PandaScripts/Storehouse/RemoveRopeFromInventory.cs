using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRopeFromInventory : MonoBehaviour
{
    [SerializeField] SpriteRenderer slot1;
    [SerializeField] SpriteRenderer slot2;
    [SerializeField] SpriteRenderer slot3;
    [SerializeField] SpriteRenderer slot4;
    [SerializeField] SpriteRenderer slot5;
    [SerializeField] Sprite blank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void removeRope() {
        if (AddRope.ropeLocation == 1 && Panda2.bambooObtained){
            slot1.sprite = blank;
            AddItemToInventory.slot1full = false;
        }
        else if (AddRope.ropeLocation == 2 && Panda2.bambooObtained){
            slot2.sprite = blank;
            AddItemToInventory.slot2full = false;
        }
        else if (AddRope.ropeLocation == 3 && Panda2.bambooObtained){
            slot3.sprite = blank;
            AddItemToInventory.slot3full = false;
        }
        else if (AddRope.ropeLocation == 4 && Panda2.bambooObtained){
            slot4.sprite = blank;
            AddItemToInventory.slot4full = false;
        }
        else if (AddRope.ropeLocation == 5 && Panda2.bambooObtained){
            slot5.sprite = blank;
            AddItemToInventory.slot5full = false;
        }
    }
}
