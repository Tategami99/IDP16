using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    public GameObject Camera;
    Vector2 InventoryArea = new Vector2 (0, 20);
    private bool showing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        if (showing){
            Camera.transform.position = InventoryArea;
        }
        
    }
}
