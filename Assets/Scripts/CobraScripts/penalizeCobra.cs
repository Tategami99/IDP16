using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  TMPro;

public class penalizeCobra : MonoBehaviour
{
    public GameObject ThHints;
    public GameObject TwHints;
    public GameObject OHint;
    public GameObject NoHints;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private string Hints3Line;
    [SerializeField] private string Hints2Line;
    [SerializeField] private string Hint1Line;
    [SerializeField] private string Hints0Line;
    public static bool HintButtonClicked = false;
    
    public static int number = 3;
    // Start is called before the first frame update
    void Start()
    {
        TwHints.SetActive(false);
        OHint.SetActive(false);
        NoHints.SetActive(false);
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
        if (number == 3){
            PandaTime.totalTimeLeft -= 60;
            CobraTime.cobraTimeSec += 60;
            Debug.Log(PandaTime.totalTimeLeft + "+" + CobraTime.cobraTimeSec);
            ThHints.SetActive(false);
            TwHints.SetActive(true);
            number -= 1;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hint1Line, textLabel);
        }
        else if(number == 2){
            PandaTime.totalTimeLeft -= 60;
            CobraTime.cobraTimeSec += 60;
            Debug.Log(PandaTime.totalTimeLeft + "+" + CobraTime.cobraTimeSec);
            TwHints.SetActive(false);
            OHint.SetActive(true);
            number -= 1;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints2Line, textLabel);
        }
        else if(number == 1){
            PandaTime.totalTimeLeft -= 60;
            CobraTime.cobraTimeSec += 60;
            Debug.Log(PandaTime.totalTimeLeft + "+" + CobraTime.cobraTimeSec);
            OHint.SetActive(false);
            NoHints.SetActive(true);
            number -= 1;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints3Line, textLabel);
        }
        else if (number == 0){
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Hints0Line, textLabel);
        }
    }
}