using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad0 : MonoBehaviour
{
    public static int num = 0;
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
        if (num <= 8){
            depotCode.text += "0";
            key.Play();
            num += 1;
        }
    }
}
