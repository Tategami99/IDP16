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
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject map;
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
    [SerializeField] private GameObject x;
    [SerializeField] private GameObject desert;
    [SerializeField] private GameObject rainforest;
    [SerializeField] private GameObject statue;
    [SerializeField] private string userLineMapClick1;
    private bool mapClickedFirstTime = false;

    //user first goes to rainforest
    [SerializeField] private List<string> userLinesRainGo = new List<string>();
    private int userLinesRainGoIndex = 0;
    private bool rainforestEntered = false;

    //user makes the fraction 1/3
    [SerializeField] private string userLineOofT1;
    [SerializeField] private GameObject up;
    [SerializeField] private GameObject down;
    [SerializeField] private GameObject left;
    [SerializeField] private GameObject right;
    [SerializeField] private GameObject reset;
    [SerializeField] private GameObject backToOutside;
    private bool OofTactive = false;

    //user makes the fraction 2/3
    [SerializeField] private string userLineTofT1;
    private bool TofTactive = false;

    //user makes the fraction 3/3
    [SerializeField] private string userLineThofT1;
    private bool ThofTactive = false;

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
        door.GetComponent<BoxCollider2D>().enabled = false;
        map.GetComponent<BoxCollider2D>().enabled = false;
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
        x.GetComponent<BoxCollider2D>().enabled = false;
        desert.GetComponent<BoxCollider2D>().enabled = false;
        rainforest.GetComponent<BoxCollider2D>().enabled = false;
        statue.GetComponent<BoxCollider2D>().enabled = false;
        mapClickedFirstTime = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineMapClick1, textLabel);
    }
    public void enterRainforest(){
        rainforestEntered = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLinesRainGo[userLinesRainGoIndex], textLabel);
        userLinesRainGoIndex += 1;
    }
    public void OofTDialogue(){
        OofTactive = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineOofT1, textLabel);
        up.GetComponent<BoxCollider2D>().enabled = false;
        down.GetComponent<BoxCollider2D>().enabled = false;
        left.GetComponent<BoxCollider2D>().enabled = false;
        right.GetComponent<BoxCollider2D>().enabled = false;
        reset.GetComponent<BoxCollider2D>().enabled = false;
        backToOutside.GetComponent<BoxCollider2D>().enabled = false;
    }
    public void TofTDialogue(){
        TofTactive = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineTofT1, textLabel);
        up.GetComponent<BoxCollider2D>().enabled = false;
        down.GetComponent<BoxCollider2D>().enabled = false;
        left.GetComponent<BoxCollider2D>().enabled = false;
        right.GetComponent<BoxCollider2D>().enabled = false;
        reset.GetComponent<BoxCollider2D>().enabled = false;
        backToOutside.GetComponent<BoxCollider2D>().enabled = false;
    }
    public void ThofTDialogue(){
        ThofTactive = true;
        resetDialogue();
        SpeakerLabel.text = Username.username;
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLineThofT1, textLabel);
        up.GetComponent<BoxCollider2D>().enabled = false;
        down.GetComponent<BoxCollider2D>().enabled = false;
        left.GetComponent<BoxCollider2D>().enabled = false;
        right.GetComponent<BoxCollider2D>().enabled = false;
        reset.GetComponent<BoxCollider2D>().enabled = false;
        backToOutside.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnMouseDown() {
        if (statueDoorClicked){
            statueDoorClicked = false;
            statueDoor.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (startedUp){
            startedUp = false;
            map.GetComponent<BoxCollider2D>().enabled = true;
            door.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (mapisObtained){
            mapisObtained = false;
            doneTalking();
        }
        if (mapClickedFirstTime){
            rainforest.GetComponent<BoxCollider2D>().enabled = true;
            mapClickedFirstTime = false;
            doneTalking();
        }
        if (rainforestEntered && userLinesRainGoIndex < 3){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:userLinesRainGo[userLinesRainGoIndex], textLabel);
            userLinesRainGoIndex += 1;
        }
        else if (rainforestEntered && userLinesRainGoIndex == 3){
            rainforestEntered = false;
            doneTalking();
        }
        if (OofTactive){
            OofTactive = false;
            up.GetComponent<BoxCollider2D>().enabled = true;
            down.GetComponent<BoxCollider2D>().enabled = true;
            left.GetComponent<BoxCollider2D>().enabled = true;
            right.GetComponent<BoxCollider2D>().enabled = true;
            reset.GetComponent<BoxCollider2D>().enabled = true;
            backToOutside.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (TofTactive){
            TofTactive = false;
            up.GetComponent<BoxCollider2D>().enabled = true;
            down.GetComponent<BoxCollider2D>().enabled = true;
            left.GetComponent<BoxCollider2D>().enabled = true;
            right.GetComponent<BoxCollider2D>().enabled = true;
            reset.GetComponent<BoxCollider2D>().enabled = true;
            backToOutside.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
        if (ThofTactive){
            ThofTactive = false;
            up.GetComponent<BoxCollider2D>().enabled = true;
            down.GetComponent<BoxCollider2D>().enabled = true;
            left.GetComponent<BoxCollider2D>().enabled = true;
            right.GetComponent<BoxCollider2D>().enabled = true;
            reset.GetComponent<BoxCollider2D>().enabled = true;
            backToOutside.GetComponent<BoxCollider2D>().enabled = true;
            doneTalking();
        }
    }
}
