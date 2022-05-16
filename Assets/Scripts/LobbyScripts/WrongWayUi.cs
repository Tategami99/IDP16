using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongWayUi : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private GameObject DialogueBox;
    [SerializeField] private GameObject Cont;
    // Start is called before the first frame update
    void Start()
    {
        DialogueBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void ShowWrongWayText(){
        DialogueBox.SetActive(true);
        Cont.GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<WrongWay>().RunWrongWay(textToType:"Maybe I should go to the Panda exhibit first.", textLabel);
    }
}