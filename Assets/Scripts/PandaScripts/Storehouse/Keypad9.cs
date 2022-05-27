using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad9 : MonoBehaviour
{
    [SerializeField] private TMP_Text depotCode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Keypad1.StorehousePasscode += "9";
        depotCode.text += "9";
    }
}
