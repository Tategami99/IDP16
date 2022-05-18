using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fragment1case : MonoBehaviour
{
    [SerializeField] private string UserLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject cont;
    public static bool case1clicked = false;
    public static bool case1unlocked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        if (Panda3.coinObtained){
            Debug.Log("yeet");
        }
        else{
            case1clicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        cont.GetComponent<PandaContinueButton>().disableUI();
    }
}