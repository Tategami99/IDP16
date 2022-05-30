using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad1 : MonoBehaviour
{
    public static string StorehousePasscode = "";
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
            StorehousePasscode += "1";
            Debug.Log(StorehousePasscode);
            caseCodedepotleft.text += "1";
            key.Play();
            Keypad0.num += 1;
        }
    }
}
