using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class key1 : MonoBehaviour
{
    [SerializeField] private TMP_Text caseCode;
    public static string fragment1Code = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        fragment1Code += "1";
        caseCode.text += "1";
    }
}
