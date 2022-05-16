using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestDialogue : MonoBehaviour
{
    [SerializeField] private float typespeed = 15f;
    private int charindex;
    public string Line1;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void typeText(TMP_Text text){
        charindex = 0;
        while (charindex < Line1.Length){
            time += Time.deltaTime * typespeed;
            charindex ++;
            text.text = Line1.Substring(0, charindex);
        }
    }
}
