using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundText : MonoBehaviour
{
    private Text backgroundText;
    // Start is called before the first frame update
    void Start()
    {
        backgroundText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void WriteText(){
        backgroundText = transform.Find("Text").GetComponent<Text>();
    }
}
