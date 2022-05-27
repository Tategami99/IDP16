using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class artifactCont : MonoBehaviour
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

    //user first enters room
    [SerializeField] private GameObject tablet;
    [SerializeField] private string userLineArtifact1;
    private bool startedUp;

    // Start is called before the first frame update
    void Start()
    {
        hintButton.SetActive(false);
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
        firstEnterRoom();
    }

    // Update is called once per frame
    void Update()
    {
        
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
    
    public void firstEnterRoom(){
        startedUp = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        tablet.SetActive(false);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineArtifact1, textLabel);
    }

    private void OnMouseDown() {
        if (startedUp){
            startedUp = false;
            tablet.SetActive(true);
            doneTalking();
        }
    }
}
