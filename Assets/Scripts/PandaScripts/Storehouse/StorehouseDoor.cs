using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StorehouseDoor : MonoBehaviour
{
    [SerializeField] private string UserLineStorehouse;
    [SerializeField] private string UserAlternateLineStorehouse;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject storeDown;
    Vector2 InTheStorehouse = new Vector2 (18, 22);
    public static bool locked = true;
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
        if (locked){
            storeDown.SetActive(false);
            Debug.Log("clicked");
            PandaContinueButton.storehouseClicked = true;
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserLineStorehouse, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (locked == false && firsttime ==0){
            GetComponent<AddRope>().ropeAdd();
            GetComponent<AddMagnifyingGlass>().magniAdd();
            storeDown.SetActive(false);
            Debug.Log("clicked");
            PandaContinueButton.storehouseClicked = true;
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserAlternateLineStorehouse, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
            firsttime += 1;
        }
    }
}