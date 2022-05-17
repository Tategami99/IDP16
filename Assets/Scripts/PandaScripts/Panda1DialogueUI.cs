using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panda1DialogueUI : MonoBehaviour
{
    [SerializeField] private string Panda1Line1;
    [SerializeField] private string UserLine1;
    [SerializeField] private string Panda1AlternateLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    public static bool P1clicked = false;
    public static bool infoObtained;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        if (Panda2.bambooObtained){
            P1clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1AlternateLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        else{
            P1clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}