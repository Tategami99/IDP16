using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panda1DialogueUI : MonoBehaviour
{
    [SerializeField] private SpriteRenderer background;
    [SerializeField] private Sprite pandawbamboo;
    [SerializeField] private string UserLine1;
    [SerializeField] private string Panda1AlternateLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject storeBuilding;
    public static bool P1clicked = false;
    public static bool infoObtained = false;
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
            infoObtained = true;
            P1clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = "Hungry Panda";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1AlternateLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
            background.sprite = pandawbamboo;
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
        storeBuilding.SetActive(false);
        cont.GetComponent<PandaContinueButton>().disableUI();
    }
}