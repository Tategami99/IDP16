
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class c8key : MonoBehaviour
{
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
            c9key.cobraStatueCode += "8";
            cobraCase.text += "8";
            key.Play();
            c0key.cNum += 1;
        }
    }
}