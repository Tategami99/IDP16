
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class c4key : MonoBehaviour
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
            c9key.cobraStatueCode += "4";
            cobraCase.text += "4";
            key.Play();
            c0key.cNum += 1;
        }

    }
}