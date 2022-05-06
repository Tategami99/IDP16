using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButtonClick : MonoBehaviour
{
    public text HintNum;
    private int number;
    // Start is called before the first frame update
    void Start()
    {
        HintNum.text = "X3";
        number = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        if (number == 3 ){
            HintNum.text = "X2";
            number -= 1;
        }
        elif (number == 2){
            HintNum.text = "X1";
            number -= 1;
        }
        elif (number == 1){
            HintNum.text = "X0";
            number -= 1;
        }
    }
}
