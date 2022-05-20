using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CobraContinue : MonoBehaviour
{
    //general objects
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject UI;
    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;

    //user first enters
    [SerializeField] private string userLineCobra1;
    private bool startedUp = false;

    //user clicks on statue door
    [SerializeField] private GameObject statueDoor;
    [SerializeField] private string userLineDoor1;
    private bool statueDoorClicked = false;

    //user obtains map
    [SerializeField] private string userLineMap1;
    private bool mapisObtained = false;

    //user clicks on map
    [SerializeField] private string userLineMapClick1;
    private bool mapClickedFirstTime = false;

    // Start is called before the first frame update
    void Start()
    {
        leftArrow.SetActive(false);
        rightArrow.SetActive(false);
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

    public void firstEnterCobra(){
        startedUp = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineCobra1, textLabel);
    }

    public void whenStatueDoorClicked(){
        statueDoorClicked = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineDoor1, textLabel);
        statueDoor.GetComponent<BoxCollider2D>().enabled = false;
    }
    public void mapObtained(){
        mapisObtained = true;
        resetDialogue();
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineMap1, textLabel);
    }
    public void mapClicked(){
        mapClickedFirstTime = true;
        resetDialogue();
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineMapClick1, textLabel);
    }

    private void OnMouseDown() {
        if (statueDoorClicked){
            statueDoorClicked = false;
            statueDoor.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (startedUp){
            startedUp = false;
            doneTalking();
        }
        if (mapisObtained){
            mapisObtained = false;
            doneTalking();
        }
        if (mapClickedFirstTime){
            mapClickedFirstTime = false;
            doneTalking();
        }
    }
}
