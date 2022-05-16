using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongWay : MonoBehaviour
{
    [SerializeField] private float writeSpeed = 15f;
    [SerializeField] private GameObject Continue;
    [SerializeField] private TMP_Text usernameLabel;
    // Start is called before the first frame update
    void Start()
    {
        Continue.GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RunWrongWay(string textToType, TMP_Text textLabel){
        StartCoroutine(ShowWrongWayText(textToType, textLabel));
    }
    IEnumerator ShowWrongWayText(string textToType, TMP_Text textLabel){
        textLabel.text = "";
        usernameLabel.text = "";
        yield return new WaitForSeconds(1);
        usernameLabel.text = Username.username;
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
        Continue.GetComponent<BoxCollider2D>().enabled = true;
    }
}
