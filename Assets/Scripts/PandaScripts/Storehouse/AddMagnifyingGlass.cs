using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMagnifyingGlass : MonoBehaviour
{
    [SerializeField] private GameObject self;
    public static bool magniObtained = false;
    public static int magniLocation = 0;
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
            magniLocation = 1;
        }
        else if (AddItemToInventory.slot2full == false){
            magniLocation = 2;
        }
        else if (AddItemToInventory.slot3full == false){
            magniLocation = 3;
        }
        else if (AddItemToInventory.slot4full == false){
            magniLocation = 4;
        }
        else if (AddItemToInventory.slot5full == false){
            magniLocation = 5;
        }
        magniObtained = true;
        GetComponent<AddItemToInventory>().Add();
        self.SetActive(false);
        Debug.Log("mgl= " + magniLocation);
    }
}