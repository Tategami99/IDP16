
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class c0key : MonoBehaviour
{
    public static int cNum;
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
        if (cNum < 3){
            c9key.cobraStatueCode += "0";
            cobraCase.text += "0";
            key.Play();
            cNum += 1;
        }
    }
}