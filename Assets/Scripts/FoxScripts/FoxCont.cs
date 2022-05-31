using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoxCont : MonoBehaviour
{
    //general objects
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;
    [SerializeField] private GameObject hintButton;

    //user first enters fox exhibit
    [SerializeField] private GameObject paths;
    [SerializeField] private string userLineFoxEnter1;
    private bool foxStarted = false;

    //user clicks on the wrong path
    [SerializeField] private string userLinePenalty1;
    private bool penaltyStarted = false;

    //user clicks on the cave gate
    [SerializeField] private string userLineGate1;
    [SerializeField] private GameObject gate;
    private bool gateUnlocked = false;

    //user submits sign password
    [SerializeField] private string userLineSign1;
    [SerializeField] private string userAlternateLineSign1;
    [SerializeField] private GameObject enterSpace, enterButton, clearButton, exitButton;
    private bool signEntered = false;

    //user submits fox password
    [SerializeField] private List<string> foxStatueDialogue = new List<string>();
    [SerializeField] private List<GameObject> foxEnterSpace = new List<GameObject>();
    [SerializeField] private List<GameObject> foxEnterButton = new List<GameObject>();
    [SerializeField] private List<GameObject> foxExitButton = new List<GameObject>();
    [SerializeField] private List<GameObject> foxClearButton = new List<GameObject>();
    [SerializeField] private GameObject threeStatues, goldenStatue;
    [SerializeField] private GameObject Camera;
    private Vector2 golden = new Vector2 (18, 0);
    private int foxIndex = 0;
    private bool foxEnterClicked = false;

    //user conversation with golden fox
    [SerializeField] private GameObject highlight;
    private List<string> goldenStatueSpeaker = new List<string>();
    private int goldenIndex = 0;

    //user clicks on the fragment
    [SerializeField] private List<string> foxFragmentDialogue = new List<string>();
    [SerializeField] private GameObject fragment3;
    // Start is called before the first frame update
    void Start()
    {
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);

        //speakers when talking with golden fox
        goldenStatueSpeaker.Add(Username.username);
        goldenStatueSpeaker.Add("Golden Fox");
        goldenStatueSpeaker.Add(Username.username);
        goldenStatueSpeaker.Add("Golden Fox");
        goldenStatueSpeaker.Add(Username.username);
        goldenStatueSpeaker.Add("Golden Fox");
        goldenStatueSpeaker.Add("Golden Fox");
        goldenStatueSpeaker.Add(Username.username);
        goldenStatueSpeaker.Add("Golden Fox");
        goldenStatueSpeaker.Add("Golden Fox");
    }
    public void disableUI(){
        UI.SetActive(false);
    }

    public void doneTalking(){
        UI.SetActive(true);
        PandaDialogueBox.SetActive(false);
    }

    public void resetDialogue(){
        PandaDialogueBox.SetActive(true);
        PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
        textLabel.text = "";
        SpeakerLabel.text = "";
        disableUI();
    }
    public void firstEnterFox(){
        foxStarted = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        paths.SetActive(false);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineFoxEnter1, textLabel);
    }
    public void penaltyDialogue(){
        penaltyStarted = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        paths.SetActive(false);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLinePenalty1, textLabel);
    }
    public void gateLockedDialogue(){
        gateUnlocked = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        gate.GetComponent<PolygonCollider2D>().enabled = false;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineGate1, textLabel);
    }
    public void signEnterDialogue(){
        signEntered = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        enterSpace.SetActive(false);
        enterButton.SetActive(false);
        clearButton.SetActive(false);
        exitButton.GetComponent<BoxCollider2D>().enabled = false;
        if (SignPassword.signPass == "foxy"){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineSign1, textLabel);
        }
        else{
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userAlternateLineSign1, textLabel);
        }
    }
    public void foxEnterDialogue(){
        foxEnterClicked = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        foxEnterSpace[foxIndex].SetActive(false);
        foxEnterButton[foxIndex].SetActive(false);
        foxClearButton[foxIndex].SetActive(false);
        foxExitButton[foxIndex].GetComponent<BoxCollider2D>().enabled = false;
        if (foxIndex == 2){
            SpeakerLabel.text = "";
            threeStatues.SetActive(false);
            goldenStatue.SetActive(true);
            Camera.transform.position = golden;
        }
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:foxStatueDialogue[foxIndex], textLabel);
    }
    private void goldenConvo(){
        PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
        textLabel.text = "";
        SpeakerLabel.text = "";
        SpeakerLabel.text = goldenStatueSpeaker[goldenIndex];
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:foxStatueDialogue[foxIndex], textLabel);
        foxIndex += 1;
        goldenIndex += 1;
    }

    private void OnMouseDown() {
        Debug.Log("clicked");
        if (foxStarted){
            foxStarted = false;
            paths.SetActive(true);
            
            doneTalking();
        }
        if (penaltyStarted){
            penaltyStarted = false;
            paths.SetActive(true);
            doneTalking();
        }
        if (gateUnlocked){
            gateUnlocked = false;
            gate.GetComponent<PolygonCollider2D>().enabled = true;
            doneTalking();
        }
        if (signEntered){
            signEntered = false;
            enterSpace.SetActive(true);
            enterButton.SetActive(true);
            clearButton.SetActive(true);
            exitButton.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (foxEnterClicked && foxIndex < 3){
            foxEnterClicked = false;
            foxEnterSpace[foxIndex].SetActive(true);
            foxEnterButton[foxIndex].SetActive(true);
            foxClearButton[foxIndex].SetActive(true);
            foxExitButton[foxIndex].GetComponent<BoxCollider2D>().enabled = true;
            foxIndex += 1;
            if (foxIndex != 3){
                doneTalking();
            }
            else{
                foxEnterClicked = true;
            }
            Debug.Log("foxIndex " + foxIndex);
        }
        else if (foxEnterClicked && foxIndex > 2 && goldenIndex < 10){
            goldenConvo();
        }
        else if (foxEnterClicked && goldenIndex == 10){
            foxEnterClicked = false;
            fragment3.GetComponent<BoxCollider2D>().enabled = true;
            highlight.SetActive(true);
            doneTalking();
        }
        if (penalizeFox.HintButtonClicked){
            penalizeFox.HintButtonClicked = false;
            hintButton.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
    }
}
