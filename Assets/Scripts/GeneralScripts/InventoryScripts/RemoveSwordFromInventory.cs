using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSwordFromInventory : MonoBehaviour
{
    [SerializeField] SpriteRenderer slot1;
    [SerializeField] SpriteRenderer slot2;
    [SerializeField] SpriteRenderer slot3;
    [SerializeField] SpriteRenderer slot4;
    [SerializeField] SpriteRenderer slot5;
    [SerializeField] Sprite coin;
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
        if (AddSword.swordLocation == 1 && AddSword.swordObtained){
            slot1.sprite = coin;
            AddItemToInventory.slot1full = true;
            coinLocation = 1;
        }
        else if (AddSword.swordLocation == 2 && AddSword.swordObtained){
            slot2.sprite = coin;
            AddItemToInventory.slot2full = true;
            coinLocation = 2;
        }
        else if (AddSword.swordLocation == 3 && AddSword.swordObtained){
            slot3.sprite = coin;
            AddItemToInventory.slot3full = true;
            coinLocation = 3;
        }
        else if (AddSword.swordLocation == 4 && AddSword.swordObtained){
            slot4.sprite = coin;
            AddItemToInventory.slot4full = true;
            coinLocation = 4;
        }
        else if (AddSword.swordLocation == 5 && AddSword.swordObtained){
            slot5.sprite = coin;
            AddItemToInventory.slot5full = true;
            coinLocation = 5;
        }
        if (AddSword.swordObtained){
            Panda3.coinObtained = true;
            AddSword.swordObtained = false;
        }
    }
}
