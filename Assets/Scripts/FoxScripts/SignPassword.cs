using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignPassword : MonoBehaviour
{
    public static string signPass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void readSignPassword(string value){
        signPass = value.ToUpper();
        Debug.Log(signPass);
    }
}
