using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keyreset : MonoBehaviour
{
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
        key1.fragment1Code = "";
        caseCode.text = "";
        key0.knum = 0;
    }
}
