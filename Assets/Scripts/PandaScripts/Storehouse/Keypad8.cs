using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Keypad1.StorehousePasscode += "8";
        Debug.Log(Keypad1.StorehousePasscode);
    }
}
