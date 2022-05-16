using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panda3 : MonoBehaviour
{
    [SerializeField] private string UserLine1;
    [SerializeField] private string UserAlternateLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    public static bool P3clicked = false;
    public static bool coinObtained = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        if (AddSword.swordObtained == false){
            P3clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        else{
            P3clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserAlternateLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}