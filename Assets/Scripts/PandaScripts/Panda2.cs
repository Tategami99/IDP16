using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panda2 : MonoBehaviour
{
    [SerializeField] private string Panda2Line1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject cont;
    public static bool P2clicked = false;
    public static bool bambooObtained = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        if (Panda3.coinObtained){
            P2clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = "Broke Panda";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2Line1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        else{
            P2clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = "Broke Panda";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2Line1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        cont.GetComponent<PandaContinueButton>().disableUI();
    }
}