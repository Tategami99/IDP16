using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeOut : MonoBehaviour
{
    [SerializeField] private CanvasGroup mainScreen, opening;
    [SerializeField] private float fadeSpeed;
    public static bool fadeOpeningIn = false;
    public static bool fadeMainOut = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("working");
        if (fadeOpeningIn){
            if (opening.alpha < 1){
                 opening.alpha += fadeSpeed;
                 Debug.Log(fadeOpeningIn);
            }
            else{
                fadeOpeningIn = false;
                Debug.Log("started");
                StartCoroutine(goUsername());
            }
        }
        if (fadeMainOut){
            if (mainScreen.alpha >= 0){
                 mainScreen.alpha -= fadeSpeed;
            }
            if (mainScreen.alpha <= 0){
                fadeMainOut = false;
                fadeOpeningIn = true;
            }
        }
    }
    IEnumerator goUsername(){
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene("Username");
        Debug.Log("done");
    }
}
