using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PandaContinueButton : MonoBehaviour
{
    [SerializeField] private string Panda1Line1;
    [SerializeField] private string Panda2UserLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject PandaN1;
    [SerializeField] private GameObject PandaN2;
    [SerializeField] private GameObject StorehouseDoor;
    [SerializeField] private GameObject StoreEnterButton;
    public static bool storehouseClicked = false;
    private int Panda1Line = 2;
    private int Panda2Line = 2;
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
        if (storehouseClicked == true){
            PandaDialogueBox.SetActive(false);
            storehouseClicked = false;
            StorehouseDoor.GetComponent<BoxCollider2D>().enabled = true;
        }
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
        if (KeypadEnter.KeypadEnterClicked){
            KeypadEnter.KeypadEnterClicked = false;
            PandaDialogueBox.SetActive(false);
            StoreEnterButton.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
