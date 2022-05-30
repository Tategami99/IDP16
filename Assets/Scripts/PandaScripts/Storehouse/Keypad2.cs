using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad2 : MonoBehaviour
{
    [SerializeField] private TMP_Text caseCodedepotleft;
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
            Keypad1.StorehousePasscode += "2";
            Debug.Log(Keypad1.StorehousePasscode);
            caseCodedepotleft.text += "2";
            key.Play();
            Keypad0.num += 1;
        }
    }
}
