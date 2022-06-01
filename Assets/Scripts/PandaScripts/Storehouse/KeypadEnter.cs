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
    [SerializeField] private GameObject highlight;
    [SerializeField] private GameObject highlight2;
    public static bool KeypadEnterClicked = false;
    public static bool solved1 = false, solved2 = false, solved3 = false;
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
        if (solved1 == false && Keypad1.StorehousePasscode == "78191823" && GoDoorsHouse.EnteredFromDoorsHouse == false && ToCase1Keypad.enteredFromcase1 == false){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForStorehouse, textLabel);
            StorehouseDoor.locked = false;
            PandaTime.Ppuzzle1Time = PandaTime.pandaTimeSec - PandaTime.Ppuzzle2Time;
            Debug.Log(PandaTime.Ppuzzle1Time + "-1");
            solved1 = true;
        }
        else if (solved2 == false && Keypad1.StorehousePasscode == "12" && GoDoorsHouse.EnteredFromDoorsHouse){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForDoorsHouse, textLabel);
            DoorsHouseDoor.DoorsHouselocked = false;
            PandaTime.Ppuzzle2Time = PandaTime.pandaTimeSec - PandaTime.Ppuzzle1Time;
            Debug.Log(PandaTime.Ppuzzle2Time + "-2");
            solved2 = true;
        }
        else if (solved3 == false && key1.fragment1Code == "13152114201914"){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForFragment1Case, textLabel);
            fragment1case.case1unlocked = true;
            highlight2.SetActive(true);
            PandaTime.Ppuzzle3Time = PandaTime.pandaTimeSec - PandaTime.Ppuzzle2Time - PandaTime.Ppuzzle1Time;
            Debug.Log(PandaTime.Ppuzzle3Time + "-3");
            solved3 = true;
        }
        else{
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Inorrect, textLabel);
        }
        self.GetComponent<BoxCollider2D>().enabled = false;
        enterDown.SetActive(false);
        cont.GetComponent<PandaContinueButton>().disableUI();
    }
}