using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorsHouseDoor : MonoBehaviour
{
    [SerializeField] private string UserLineDoorsHouse;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject Camera;
    Vector2 InTheDoorsHouse = new Vector2 (-18, 22);
    public static bool DoorsHouselocked = true;
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
        else{
            Camera.transform.position = InTheDoorsHouse;
        }
    }
}