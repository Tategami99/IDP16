using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject InventoryArea;
    private bool showing;
    // Start is called before the first frame update
    void Start()
    {
        InventoryArea.SetActive(false);
        showing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if(showing){
            InventoryArea.SetActive(false);
            showing = false;
        }
        else{
            InventoryArea.SetActive(true);
            showing = true;
        }
    }
}
