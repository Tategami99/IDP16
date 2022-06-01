using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  TMPro;

public class penalizeFox : MonoBehaviour
{
    [SerializeField] private List<GameObject> hintLabel = new List<GameObject>();
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private string Hints3Line;
    [SerializeField] private string Hints2Line;
    [SerializeField] private string Hint1Line;
    [SerializeField] private string Hints0Line;
    [SerializeField] private string wrongAreaLine;
    public static bool HintButtonClicked = false;
    public static string playerLocation;
    private bool eUsed = false, sUsed = false, siUsed = false;
    
    public static int number = 3;
    // Start is called before the first frame update
    void Start()
    {
        hintLabel[0].SetActive(false);hintLabel[1].SetActive(false);hintLabel[2].SetActive(false);
        hintLabel[3].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (number >= 0){
            HintButtonClicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        if(playerLocation == "echo" && eUsed == false){
            echoHint();
            number -= 1;
            changeLabel();
        }
        else if(playerLocation == "statue" && sUsed == false){
            statueHint();
            number -= 1;
            changeLabel();
        }
        else if (playerLocation == "sign" && siUsed == false){
           signHint();
           number -= 1;
           changeLabel();
        }
        else if (number == 0){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints0Line, textLabel);
        }
        else{
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:wrongAreaLine, textLabel);
        }
    }
    private void echoHint(){
        PandaTime.totalTimeLeft -= 90;
        FoxTime.foxTimeSec += 90;
        Debug.Log(PandaTime.totalTimeLeft + "+" + FoxTime.foxTimeSec);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints3Line, textLabel);
        eUsed = true;
    }
    private void statueHint(){
        PandaTime.totalTimeLeft -= 75;
        FoxTime.foxTimeSec += 75;
        Debug.Log(PandaTime.totalTimeLeft + "+" + FoxTime.foxTimeSec);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints2Line, textLabel);
        sUsed = true;
    }
    private void signHint(){
        PandaTime.totalTimeLeft -= 60;
        FoxTime.foxTimeSec += 60;
        Debug.Log(PandaTime.totalTimeLeft + "+" + FoxTime.foxTimeSec);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hint1Line, textLabel);
        siUsed = true;
    }
    private void changeLabel(){
        for (int i = 0; i < 4; i++){
            hintLabel[i].SetActive(false);
        }
        hintLabel[number].SetActive(true);
    }
}