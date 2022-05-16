using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadEnter : MonoBehaviour
{
    [SerializeField] private string CorrectForStorehouse;
    [SerializeField] private string CorrectForDoorsHouse;
    [SerializeField] private string Inorrect;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
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
        if (Keypad1.StorehousePasscode == "222318218111824228" && GoDoorsHouse.EnteredFromDoorsHouse == false){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForStorehouse, textLabel);
            StorehouseDoor.locked = false;
        }
        else if (Keypad1.StorehousePasscode == "16" && GoDoorsHouse.EnteredFromDoorsHouse){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:CorrectForDoorsHouse, textLabel);
            DoorsHouseDoor.DoorsHouselocked = false;
        }
        else{
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Inorrect, textLabel);
        }
        self.GetComponent<BoxCollider2D>().enabled = false;
    }
}