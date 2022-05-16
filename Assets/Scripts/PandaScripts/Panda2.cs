using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Panda2 : MonoBehaviour
{
    [SerializeField] private string Panda2Line1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    public static bool P2clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        P2clicked = true;
        Debug.Log("clicked");
        PandaDialogueBox.SetActive(true);
        PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
        textLabel.text = "";
        SpeakerLabel.text = "";
        SpeakerLabel.text = "Panda 2";
        GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:Panda2Line1, textLabel);
        self.GetComponent<BoxCollider2D>().enabled = false;
    }
}