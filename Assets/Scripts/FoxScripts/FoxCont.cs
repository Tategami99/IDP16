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

    //user first enters fox exhibit
    [SerializeField] private GameObject firstPath, secondPath, thirdPath;
    [SerializeField] private string userLineFoxEnter1;
    private bool foxStarted = false;

    //user clicks on the wrong path
    [SerializeField] private string userLinePenalty1;
    private bool penaltyStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
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
        firstPath.GetComponent<BoxCollider2D>().enabled = false;
        secondPath.GetComponent<BoxCollider2D>().enabled = false;
        thirdPath.GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineFoxEnter1, textLabel);
    }
    public void penaltyDialogue(){
        penaltyStarted = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        firstPath.GetComponent<BoxCollider2D>().enabled = false;
        secondPath.GetComponent<BoxCollider2D>().enabled = false;
        thirdPath.GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLinePenalty1, textLabel);
    }

    private void OnMouseDown() {
        if (foxStarted){
            foxStarted = false;
            firstPath.GetComponent<BoxCollider2D>().enabled = true;
            secondPath.GetComponent<BoxCollider2D>().enabled = true;
            thirdPath.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (penaltyStarted){
            penaltyStarted = false;
            firstPath.GetComponent<BoxCollider2D>().enabled = true;
            secondPath.GetComponent<BoxCollider2D>().enabled = true;
            thirdPath.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
    }
}
