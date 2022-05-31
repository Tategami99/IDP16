using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class resetButton : MonoBehaviour
{
    [SerializeField] private TMP_Text coords;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        upArrow.xC = 0;
        upArrow.yC = 0;
        coords.text = "(0, 0)";
    }
}
