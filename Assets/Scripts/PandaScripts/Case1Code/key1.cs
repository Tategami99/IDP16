using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class key1 : MonoBehaviour
{
    [SerializeField] private TMP_Text caseCode;
    public static string fragment1Code = "";
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
            fragment1Code += "1";
            caseCode.text += "1";
            key0.knum += 1;
        }
    }
}
