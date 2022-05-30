using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadReset : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text caseCodedepotleft; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Keypad1.StorehousePasscode = "";
        Debug.Log(Keypad1.StorehousePasscode);
        caseCodedepotleft.text = "";
        Keypad0.num = 0;
    }
}
