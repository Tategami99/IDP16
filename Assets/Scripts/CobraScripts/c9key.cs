using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class c9key : MonoBehaviour
{
    public static string cobraStatueCode = "";
    [SerializeField] TMP_Text cobraCase;
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
        cobraStatueCode += "9";
        cobraCase.text += "9";

    }
}
