using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panda1Dialogue : MonoBehaviour
{
    [SerializeField] private float Panda1TypeSpeed = 15f;
    [SerializeField] private GameObject Panda1Continue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RunPanda1Dialogue(string textToType, TMP_Text textLabel){
        StartCoroutine(ShowPanda1Dialogue(textToType, textLabel));
    }
    public void StopPanda1Dialogue(string textToType, TMP_Text textLabel){
        StopCoroutine(ShowPanda1Dialogue(textToType, textLabel));
    }
    IEnumerator ShowPanda1Dialogue(string textToType, TMP_Text textLabel){
        float t = 0;
        int charIndex = 0;
        while (charIndex < textToType.Length){
            t += Time.deltaTime * Panda1TypeSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);
            textLabel.text = textToType.Substring(0, charIndex);  
            yield return null;
        }
        textLabel.text = textToType;
        Panda1Continue.GetComponent<BoxCollider2D>().enabled = true;
    }
}
