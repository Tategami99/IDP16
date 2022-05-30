using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad7 : MonoBehaviour
{
    [SerializeField] private TMP_Text depotCode;
    [SerializeField] private AudioSource key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (Keypad0.num <= 8){
            Keypad1.StorehousePasscode += "7";
            Debug.Log(Keypad1.StorehousePasscode);
            depotCode.text += "7";
            key.Play();
            Keypad0.num += 1;
        }
    }
}
