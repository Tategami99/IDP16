using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAnswers : MonoBehaviour
{
    public static string experience;
    public static string entertaining;
    public static string difficult;
    public static string improve;
    public static string issues;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exp(string nce){
        experience = nce;
        Debug.Log(experience);
    }
    public void ent(string ing){
        entertaining = ing;
        Debug.Log(entertaining);
    }
    public void dif(string ult){
        difficult = ult;
        Debug.Log(difficult);
    }
    public void imp(string ove){
        improve = ove;
        Debug.Log(improve);
    }
    public void iss(string ues){
        issues = ues;
        Debug.Log(issues);
    }
}
