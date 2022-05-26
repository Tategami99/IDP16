using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statuePasswords : MonoBehaviour
{
    public static int numCorrect = 0;
    public static string s1pass;
    public static string s2pass;
    public static string s3pass;
    
    public void reads1(string v1){
        s1pass = v1;
        Debug.Log(s1pass);
    }
    public void reads2(string v2){
        s2pass = v2;
        Debug.Log(s2pass);
    }
    public void reads3(string v3){
        s3pass = v3;
        Debug.Log(s3pass);
    }
}
