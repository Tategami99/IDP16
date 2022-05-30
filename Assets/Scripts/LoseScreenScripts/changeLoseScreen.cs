using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLoseScreen : MonoBehaviour
{
    [SerializeField] private SpriteRenderer background;
    [SerializeField] private Sprite red, blue;
    [SerializeField] private GameObject loseButton;
    private bool redCheck = true;
    private bool firsttime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(changeColor());
        StartCoroutine(check());
    }
    IEnumerator changeColor(){
        if (redCheck){
            yield return new WaitForSecondsRealtime(1);
            background.sprite = blue;
            redCheck = false;
        }
        else{
            yield return new WaitForSecondsRealtime(1);
            background.sprite = red;
            redCheck = true;
        }
    }
    IEnumerator check(){
        if (firsttime){
            firsttime = false;
            yield return new WaitForSeconds(6);
            loseButton.SetActive(true);
            
        }
    }
}
