using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    [SerializeField] private SpriteRenderer self;
    [SerializeField] private Sprite backpack;
    [SerializeField] private Sprite x;
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
            self.sprite = backpack;
        }
        else{
            InventoryArea.SetActive(true);
            showing = true;
            self.sprite = x;
        }
    }
}
