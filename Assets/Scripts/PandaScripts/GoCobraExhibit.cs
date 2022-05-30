using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCobraExhibit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log(PandaTime.pandaTimeSec + "-total  actualTotal= " + PandaTime.Ppuzzle1Time + PandaTime.Ppuzzle2Time + PandaTime.Ppuzzle3Time);
        SceneManager.LoadScene("CobraExhibit");
        Debug.Log("clicked");
    }
}
