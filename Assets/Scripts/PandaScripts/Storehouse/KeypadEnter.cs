using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadEnter : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    [SerializeField] private string CorrectForStorehouse;
    [SerializeField] private string CorrectForDoorsHouse;
    [SerializeField] private string CorrectForFragment1Case;
    [SerializeField] private string Inorrect;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject enterDown;
    public static bool KeypadEnterClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        KeypadEnterClicked = true;
        Debug.Log("clicked");
        PandaDialogueBox.SetActive(true);
        PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
        textLabel.text = "";
        SpeakerLabel.text = "";
        SpeakerLabel.text = Username.username;
        if (Keypad1.StorehousePasscode == "78191823" && GoDoorsHouse.EnteredFromDoorsHouse == false && ToCase1Keypad.enteredFromcase1 == false){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForStorehouse, textLabel);
            StorehouseDoor.locked = false;
        }
        else if (Keypad1.StorehousePasscode == "12" && GoDoorsHouse.EnteredFromDoorsHouse){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForDoorsHouse, textLabel);
            DoorsHouseDoor.DoorsHouselocked = false;
        }
        else if (key1.fragment1Code == "13152114201914"){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForFragment1Case, textLabel);
            fragment1case.case1unlocked = true;
        }
        else{
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Inorrect, textLabel);
        }
        self.GetComponent<BoxCollider2D>().enabled = false;
        enterDown.SetActive(false);
        cont.GetComponent<PandaContinueButton>().disableUI();
    }
}