using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumOHint : MonoBehaviour
{
    public GameObject ThHints;
    public GameObject TwHints;
    public GameObject OHint;
    public GameObject NoHints;
    
    static int number;
    // Start is called before the first frame update
    void Start()
    {
        TwHints.SetActive(false);
        OHint.SetActive(false);
        NoHints.SetActive(false);
        number = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (number == 3){
            ThHints.SetActive(false);
            TwHints.SetActive(true);
        }
        else if(number == 2){
            TwHints.SetActive(false);
            OHint.SetActive(true);
        }
        else if(number == 1){
            OHint.SetActive(false);
            NoHints.SetActive(true);
        }
        if (number > 0){
            number -= 1;
        }
    }
}