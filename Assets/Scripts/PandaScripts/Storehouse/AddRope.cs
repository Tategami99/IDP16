using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRope : MonoBehaviour
{
    [SerializeField] private GameObject self;
    public static bool ropeObtained = false;
    public static int ropeLocation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (AddItemToInventory.slot1full == false){
            ropeLocation = 1;
        }
        else if (AddItemToInventory.slot2full == false){
            ropeLocation = 2;
        }
        else if (AddItemToInventory.slot3full == false){
            ropeLocation = 3;
        }
        else if (AddItemToInventory.slot4full == false){
            ropeLocation = 4;
        }
        else if (AddItemToInventory.slot5full == false){
            ropeLocation = 5;
        }
        ropeObtained = true;
        GetComponent<AddItemToInventory>().Add();
        self.SetActive(false);
        Debug.Log("rl= " + ropeLocation);
    }
}
