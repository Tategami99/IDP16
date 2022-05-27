using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PandaContinueButton : MonoBehaviour
{
    // lines talking w/ panda 1
    [SerializeField] private string Panda1Line1;
    [SerializeField] private string Panda1AlternateUserLine1;
    [SerializeField] private string Panda1AlternateLine2;
    [SerializeField] private string Panda1AlternateUserLine2;
    //lines talking w/ panda 2
    [SerializeField] private string Panda2UserLine1;
    [SerializeField] private string Panda2AlternateUserLine1;
    [SerializeField] private string Panda2AlternatePandaLine2;
    [SerializeField] private string NarratorLine2;
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
    [SerializeField] private GameObject DoorhouseDoor;
    [SerializeField] private GameObject StoreEnterButton;
    [SerializeField] private GameObject HintButton;
    [SerializeField] private GameObject Gate;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject enterDown;
    [SerializeField] private GameObject storeDown;
    [SerializeField] private GameObject doorDown;
    [SerializeField] private GameObject PlaceRope;
    [SerializeField] private GameObject BackFromSmallMark;
    [SerializeField] private GameObject frag1case;
    [SerializeField] private GameObject enterFragDown;
    [SerializeField] private GameObject mark;
    [SerializeField] private GameObject case1Keypad;
    [SerializeField] private GameObject caseEnterKey;
    [SerializeField] private GameObject enterCaseDown;
    public static bool storehouseClicked = false;
    private int Panda1Line = 2;
    private int Panda2Line = 2;
    private int Panda3Line = 2;

    //stuff when you obtain the fragment
    private int fragment1Line = 2;
    [SerializeField] private string UserCaseLine2;
    [SerializeField] private string UserCaseLine3;
    [SerializeField] private SpriteRenderer mountainTopBackground;
    [SerializeField] private Sprite backgroundWithDoor;
    [SerializeField] private GameObject mountainTopDoor;

    // Start is called before the first frame update
    void Start()
    {
        PandaDialogueBox.SetActive(false);
        mountainTopDoor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void disableUI(){
        UI.SetActive(false);
    }

    public void enableUI(){
        UI.SetActive(true);
    }

    public void OnMouseDown(){
        Debug.Log("clicked");
        PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
        textLabel.text = "";
        SpeakerLabel.text = "";
        // Panda 1 lines
        if (Panda1Line == 2 && Panda1DialogueUI.P1clicked){
            if (Panda1DialogueUI.infoObtained){
                SpeakerLabel.text = Username.username;
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1AlternateUserLine1, textLabel);
                Gate.SetActive(true);
                Panda1Line += 1;
            }
            else{
                SpeakerLabel.text = "Hungry Panda";
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1Line1, textLabel);
                Panda1Line += 1;
                Debug.Log("run second line");
            }
        }
        else if (Panda1Line == 3 && Panda1DialogueUI.P1clicked){
            if (Panda1DialogueUI.infoObtained){
                SpeakerLabel.text = "Hungry Panda";
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1AlternateLine2, textLabel);
                Panda1Line += 1;
            }
            else{
                Panda1DialogueUI.P1clicked = false;
                PandaDialogueBox.SetActive(false);
                PandaN1.GetComponent<BoxCollider2D>().enabled = true;
                Panda1Line = 2;
                enableUI();
            }
        }
        else if (Panda1Line == 4 && Panda1DialogueUI.P1clicked){
            if (Panda1DialogueUI.infoObtained){
                SpeakerLabel.text = Username.username;
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda1AlternateUserLine2, textLabel);
                Panda1Line += 1;
            }
        }
        else if (Panda1Line == 5){
            Panda1DialogueUI.P1clicked = false;
            PandaDialogueBox.SetActive(false);
            PandaN1.GetComponent<BoxCollider2D>().enabled = false;
            Panda1Line += 1;
            Gate.SetActive(true);
            enableUI();
        }

        // lines when u click on the storehouse
        if (storehouseClicked == true){
            PandaDialogueBox.SetActive(false);
            storehouseClicked = false;
            StorehouseDoor.GetComponent<BoxCollider2D>().enabled = true;
            DoorhouseDoor.GetComponent<BoxCollider2D>().enabled = true;
            storeDown.SetActive(true);
            doorDown.SetActive(true);
        }

        // Panda 2 lines
        if (Panda2Line == 2 && Panda2.P2clicked){
            if (Panda2.bambooObtained){
                SpeakerLabel.text = Username.username;
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2AlternateUserLine1, textLabel);
            }
            else{
                SpeakerLabel.text = Username.username;
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2UserLine1, textLabel);
            }
            Panda2Line += 1;
        }
        else if (Panda2Line == 3 && Panda2.P2clicked){
            if (Panda2.bambooObtained){
                SpeakerLabel.text = "Broke Panda";
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2AlternatePandaLine2, textLabel);
                Panda2Line += 1;
            }
            else{
                Panda2.P2clicked = false;
                PandaDialogueBox.SetActive(false);
                PandaN2.GetComponent<BoxCollider2D>().enabled = true;
                Panda2Line = 2;
                enableUI();
            }
        }
        else if (Panda2Line == 4 && Panda2.P2clicked){
            SpeakerLabel.text = "";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:NarratorLine2, textLabel);
            Panda2Line += 1;
        }
        else if (Panda2Line == 5 && Panda2.P2clicked){
            Panda2.P2clicked = false;
            PandaDialogueBox.SetActive(false);
            PandaN2.GetComponent<BoxCollider2D>().enabled = false;
            enableUI();
        }

        // lines when u click on the enter button on the keypad
        if (KeypadEnter.KeypadEnterClicked){
            KeypadEnter.KeypadEnterClicked = false;
            PandaDialogueBox.SetActive(false);
            StoreEnterButton.GetComponent<BoxCollider2D>().enabled = true;
            caseEnterKey.GetComponent<BoxCollider2D>().enabled = true;
            enterDown.SetActive(true);
            enterCaseDown.SetActive(true);
            enterFragDown.SetActive(true);
            enableUI();
        }
        
        // Panda 3 lines
        if (Panda3Line == 2 && Panda3.P3clicked){
            SpeakerLabel.text = "Rich Panda";
            if (Panda3.coinObtained){
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3AlternateLine1, textLabel);
            }
            else{
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3Line1, textLabel);
            }
            Panda3Line += 1;
        }
        else if (Panda3Line == 3 && Panda3.P3clicked){
            if (Panda3.coinObtained){
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:NarratorLine1, textLabel);
                Panda3Line = 7;
            }
            else{
                SpeakerLabel.text = Username.username;
                GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda3UserLine2, textLabel);
                Panda3Line += 1;
            }
        }
        else if (Panda3Line == 4 && Panda3.P3clicked){
            SpeakerLabel.text = "Rich Panda";
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
            Panda3Line = 2;
            enableUI();
        }
        else if (Panda3Line == 7 && Panda3.P3clicked){
            Panda3.P3clicked = false;
            PandaDialogueBox.SetActive(false);
            PandaN3.GetComponent<BoxCollider2D>().enabled = false;
            Panda3Line = 2;
            enableUI();
        }

        // lines when u click on the hint button
        if (NumOHint.HintButtonClicked){
            NumOHint.HintButtonClicked = false;
            PandaDialogueBox.SetActive(false);
            HintButton.GetComponent<BoxCollider2D>().enabled = true;
        }

        // lines when u click to place the rope
        if (PlaceTheRope.PlaceRopeClicked){
            PlaceTheRope.PlaceRopeClicked = false;
            PandaDialogueBox.SetActive(false);
            PlaceRope.GetComponent<BoxCollider2D>().enabled = true;
            enableUI();
        }

        // lines when u click on the small mark
        if (ToMagniScreen.magniScreenclicked){
            ToMagniScreen.magniScreenclicked = false;
            PandaDialogueBox.SetActive(false);
            BackFromSmallMark.SetActive(true);
            enterDown.SetActive(true);
            enableUI();
        }
        
        //lines when u click on the fragment
        if (fragment1case.case1clicked && fragment1Line == 2 && fragment1case.case1unlocked){
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserCaseLine2, textLabel);
            fragment1Line += 2;
            Debug.Log("happened");
            
        }
        else if (fragment1case.case1clicked && fragment1Line == 3 && fragment1case.case1unlocked){
            mountainTopBackground.sprite = backgroundWithDoor;
            fragment1Line += 1;
        }
        else if (fragment1case.case1clicked && fragment1Line == 4 && fragment1case.case1unlocked){
            mountainTopBackground.sprite = backgroundWithDoor;
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserCaseLine3, textLabel);
            fragment1Line += 1;
        }
        else if (fragment1case.case1clicked && fragment1Line == 5 && fragment1case.case1unlocked){
            fragment1case.case1clicked = false;
            mountainTopDoor.SetActive(true);
            Debug.Log("enabled");
            PandaDialogueBox.SetActive(false);
            enableUI();
        }
        else if (fragment1case.case1unlocked == false && fragment1case.case1clicked){
            frag1case.GetComponent<BoxCollider2D>().enabled = true;
            mark.GetComponent<BoxCollider2D>().enabled = true;
            case1Keypad.GetComponent<BoxCollider2D>().enabled = true;
            PandaDialogueBox.SetActive(false);
        }
    }
}
