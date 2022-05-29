using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryHighlight : MonoBehaviour
{
    private bool firsttime = true;
    [SerializeField] private GameObject highlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (firsttime){
            highlight.SetActive(false);
            firsttime = false;
        }
    }
}
