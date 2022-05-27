using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad5 : MonoBehaviour
{
    [SerializeField] private TMP_Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        textBox.text += "5";
        Keypad1.StorehousePasscode += "5";
    }
}
