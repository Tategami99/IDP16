using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSword : MonoBehaviour
{
    public static bool swordObtained = false;
    public static int swordLocation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void swordAdd() {
        if (AddItemToInventory.slot1full == false){
            swordLocation = 1;
        }
        else if (AddItemToInventory.slot2full == false){
            swordLocation = 2;
        }
        else if (AddItemToInventory.slot3full == false){
            swordLocation = 3;
        }
        else if (AddItemToInventory.slot4full == false){
            swordLocation = 4;
        }
        else if (AddItemToInventory.slot5full == false){
            swordLocation = 5;
        }
        swordObtained = true;
        GetComponent<AddItemToInventory>().Add();
        Debug.Log("sl= " + swordLocation);
    }
}
