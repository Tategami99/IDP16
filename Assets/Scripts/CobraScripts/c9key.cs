using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class c9key : MonoBehaviour
{
    public static string cobraStatueCode = "";
    [SerializeField] TMP_Text cobraCase;
    [SerializeField] private AudioSource key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (c0key.cNum < 3){
            cobraStatueCode += "9";
            cobraCase.text += "9";
            key.Play();
            c0key.cNum += 1;
        }
    }
}
