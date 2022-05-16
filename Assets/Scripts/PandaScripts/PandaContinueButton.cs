using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PandaContinueButton : MonoBehaviour
{
    // lines talking w/ panda 1
    [SerializeField] private string Panda1Line1;
    //lines talking w/ panda 2
    [SerializeField] private string Panda2UserLine1;
    //lines talking w/ panda 3
    [SerializeField] private string Panda3Line1;
    [SerializeField] private string Panda3AlternateLine1;
    [SerializeField] private string Panda3UserLine2;
    [SerializeField] private string NarratorLine1;
    [SerializeField] private string Panda3Line2;
    [SerializeField] private string Panda3UserLine3;

    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject PandaN1;
    [SerializeField] private GameObject PandaN2;
    [SerializeField] private GameObject PandaN3;
    [SerializeField] private GameObject StorehouseDoor;
    [SerializeField] private GameObject StoreEnterButton;
    [SerializeField] private GameObject HintButton;
    public static bool storehouseClicked = false;
    private int Panda1Line = 2;
    private int Panda2Line = 2;
    private int Panda3Line = 2;
    // Start is called before the first frame update
    void Start()
    {
        PandaDialogueBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        Debug.Log("clicked");
        PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
        textLabel.text = "";
        SpeakerLabel.text = "";
        // Panda 1 lines
        if (Panda1Line == 2 && Panda1DialogueUI.P1clicked){
            SpeakerLabel.text = "Panda";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1Line1, textLabel);
            Panda1Line += 1;
        }
        else if (Panda1Line == 3 && Panda1DialogueUI.P1clicked){
            Panda1DialogueUI.P1clicked = false;
            PandaDialogueBox.SetActive(false);
            PandaN1.GetComponent<BoxCollider2D>().enabled = true;
            Panda1Line += 1;
        }

        // lines when u click on the storehouse
        if (storehouseClicked == true){
            PandaDialogueBox.SetActive(false);
            storehouseClicked = false;
            StorehouseDoor.GetComponent<BoxCollider2D>().enabled = true;
        }

        // Panda 2 lines
        if (Panda2Line == 2 && Panda2.P2clicked){
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2UserLine1, textLabel);
            Panda2Line += 1;
        }
        else if (Panda2Line == 3 && Panda2.P2clicked){
            Panda2.P2clicked = false;
            PandaDialogueBox.SetActive(false);
            PandaN2.GetComponent<BoxCollider2D>().enabled = true;
        }

        // lines when u click on the enter button on the keypad
        if (KeypadEnter.KeypadEnterClicked){
            KeypadEnter.KeypadEnterClicked = false;
            PandaDialogueBox.SetActive(false);
            StoreEnterButton.GetComponent<BoxCollider2D>().enabled = true;
        }
        
        // Panda 3 lines
        if (Panda3Line == 2 && Panda3.P3clicked){
            SpeakerLabel.text = "Panda 3";
            if (AddSword.swordObtained){
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3AlternateLine1, textLabel);
            }
            else{
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3Line1, textLabel);
            }
            Panda3Line += 1;
        }
        else if (Panda3Line == 3 && Panda3.P3clicked){
            if (AddSword.swordObtained){
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:NarratorLine1, textLabel);
                Panda3.coinObtained = true;
                Panda3Line = 6;
            }
            else{
                SpeakerLabel.text = Username.username;
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3UserLine2, textLabel);
                Panda3Line += 1;
            }
        }
        else if (Panda3Line == 4 && Panda3.P3clicked){
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3Line2, textLabel);
            Panda3Line += 1;
        }
        else if (Panda3Line == 5 && Panda3.P3clicked){
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3UserLine3, textLabel);
            Panda3Line += 1;
        }
        else if (Panda3Line == 6 && Panda3.P3clicked){
            Panda3.P3clicked = false;
            PandaDialogueBox.SetActive(false);
            PandaN3.GetComponent<BoxCollider2D>().enabled = true;
        }

        // lines when u click on the hint button
        if (NumOHint.HintButtonClicked){
            NumOHint.HintButtonClicked = false;
            PandaDialogueBox.SetActive(false);
            HintButton.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
