using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorsHouseDoor : MonoBehaviour
{
    [SerializeField] private string UserLineDoorsHouse;
    [SerializeField] private string UserAlternateLineDoorsHouse;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject doorDown;
    [SerializeField] private GameObject highlight;
    [SerializeField] private AudioSource doorLocked, notLocked;
    Vector2 InTheDoorsHouse = new Vector2 (-18, 22);
    public static bool DoorsHouselocked = true;
    private int firsttime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        if (DoorsHouselocked){
            doorLocked.Play();
            doorDown.SetActive(false);
            Debug.Log("clicked");
            PandaContinueButton.storehouseClicked = true;
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserLineDoorsHouse, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (DoorsHouselocked == false && firsttime == 0){
            notLocked.Play();
            highlight.SetActive(false);
            GetComponent<AddSword>().swordAdd();
            doorDown.SetActive(false);
            Debug.Log("clicked");
            PandaContinueButton.storehouseClicked = true;
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserAlternateLineDoorsHouse, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
            firsttime += 1;
        }
    }
}