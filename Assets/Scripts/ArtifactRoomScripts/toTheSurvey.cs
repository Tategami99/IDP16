using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTheSurvey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void survey(){
        StartCoroutine(wait());
    }
    IEnumerator wait(){
        yield return new WaitForSecondsRealtime(8);
        SceneManager.LoadScene("TestScene"); 
    }
}
