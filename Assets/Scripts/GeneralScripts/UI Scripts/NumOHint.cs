using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  TMPro;

public class NumOHint : MonoBehaviour
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
    private bool sUsed = false, dUsed = false, cUsed = false;
    
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
        if (playerLocation == "storehouse" && sUsed == false){
            store();
            number -= 1;
            changeLabel();
        }
        else if(playerLocation == "doorhouse" && dUsed == false){
            door();
            number -= 1;
            changeLabel();
        }
        else if(playerLocation == "case" && cUsed == false){
            artifact();
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
    private void store(){
        PandaTime.totalTimeLeft -= 60;
        PandaTime.pandaTimeSec += 60;
        Debug.Log(PandaTime.totalTimeLeft + "+" + PandaTime.pandaTimeSec);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hint1Line, textLabel);
        sUsed = true;
    }
    private void door(){
        PandaTime.totalTimeLeft -= 60;
        PandaTime.pandaTimeSec += 60;
        Debug.Log(PandaTime.totalTimeLeft + "+" + PandaTime.pandaTimeSec);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints2Line, textLabel);
        dUsed = true;
    }
    private void artifact(){
        PandaTime.totalTimeLeft -= 60;
        PandaTime.pandaTimeSec += 60;
        Debug.Log(PandaTime.totalTimeLeft + "+" + PandaTime.pandaTimeSec);
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints3Line, textLabel);
        cUsed = true;
    }
    private void changeLabel(){
        for (int i = 0; i < 4; i++){
            hintLabel[i].SetActive(false);
        }
        hintLabel[number].SetActive(true);
    }
}