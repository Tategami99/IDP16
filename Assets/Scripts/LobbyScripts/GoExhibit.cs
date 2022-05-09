using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoExhibit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goPexhibit(){
        SceneManager.LoadScene("PandaExhibit");
    }
    public void goCexhibit(){
        SceneManager.LoadScene("CobraExhibit");
    }
    public void goFexhibit(){
        SceneManager.LoadScene("FoxExhibit");
    }
}
