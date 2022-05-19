using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToMagniScreen : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 tinyMark = new Vector2 (36, 0);
    [SerializeField] private string UserAlternateline1;
    [SerializeField] private string UserLine1;
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private TMP_Text SpeakerLabel;
    [SerializeField] private GameObject PandaDialogueBox;
    [SerializeField] private GameObject PandaContinue;
    [SerializeField] private GameObject BackFromSmallMark;
    [SerializeField] private GameObject cont;
    public static bool magniScreenclicked = false;
    private int firsttime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (firsttime == 1){
            Camera.transform.position = tinyMark;
        }
        if (firsttime == 0 && AddMagnifyingGlass.magniObtained){
            Camera.transform.position = tinyMark;
            magniScreenclicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserAlternateline1, textLabel);
            BackFromSmallMark.SetActive(false);
            firsttime += 1;
            cont.GetComponent<PandaContinueButton>().disableUI();
        }
        else{
            magniScreenclicked = true;
            Debug.Log("clicked");
            PandaDialogueBox.SetActive(true);
            PandaContinue.GetComponent<BoxCollider2D>().enabled = false;
            textLabel.text = "";
            SpeakerLabel.text = "";
            SpeakerLabel.text = Username.username;
            GetComponent<Panda1Dialogue>().RunPanda1Dialogue(textToType:UserLine1, textLabel);
            cont.GetComponent<PandaContinueButton>().disableUI();
        }
    }
}
