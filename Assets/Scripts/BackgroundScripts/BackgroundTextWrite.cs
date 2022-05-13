using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BackgroundTextWrite : MonoBehaviour
{
    [SerializeField] private float writeSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Run(string textToType, TMP_Text textLabel){
        StartCoroutine(ShowText(textToType, textLabel));
    }
    IEnumerator ShowText(string textToType, TMP_Text textLabel){
        yield return new WaitForSeconds(2);
        float t = 0;
        int charIndex = 0;
        while (charIndex < textToType.Length){
            t += Time.deltaTime * writeSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);
            textLabel.text = textToType.Substring(0, charIndex);  
            yield return null;
        }
        textLabel.text = textToType;
    }
}
