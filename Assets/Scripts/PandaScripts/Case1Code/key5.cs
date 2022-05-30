using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class key5 : MonoBehaviour
{
    [SerializeField] private TMP_Text caseCode;
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
        if (key0.knum <= 14){
            key.Play();
            key1.fragment1Code += "5";
            caseCode.text += "5";
            key0.knum += 1;
        }
    }
}
