using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class key8 : MonoBehaviour
{
    [SerializeField] private AudioSource key;
    [SerializeField] private TMP_Text caseCode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (key0.knum <= 14){
            key.Play();
            key1.fragment1Code += "8";
            caseCode.text += "8";
            key0.knum += 1;
        }
    }
}
