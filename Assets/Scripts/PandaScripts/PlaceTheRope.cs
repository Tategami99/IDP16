using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaceTheRope : MonoBehaviour
{
    [SerializeField] private string NarratorLine1;
    [SerializeField] private string NarratorAlternateLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject withRope;
    Vector2 path = new Vector2 (18, -11);
    public static bool PlaceRopeClicked = false;
    private int placement = 0;
    // Start is called before the first frame update
    void Start()
    {
        withRope.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void OnMouseDown(){
        if (placement == 1){
            Debug.Log("place");
            Camera.transform.position = path;
        }
        if (AddRope.ropeObtained && placement == 0){
            PlaceRopeClicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:NarratorAlternateLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<RemoveRopeFromInventory>().removeRope();
            placement += 1;
            withRope.SetActive(true);
        }
        else if (AddRope.ropeObtained == false){
            PlaceRopeClicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:NarratorLine1, textLabel);
            self.GetComponent<BoxCollider2D>().enabled = false;
        }
        cont.GetComponent<PandaContinueButton>().disableUI();
    }
}