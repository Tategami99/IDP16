using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cClearKey : MonoBehaviour
{
    [SerializeField] private TMP_Text code;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        code.text = "";
        c9key.cobraStatueCode = "";
    }
}
