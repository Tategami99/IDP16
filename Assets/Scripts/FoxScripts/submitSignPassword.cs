using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitSignPassword : MonoBehaviour
{
    [SerializeField] private SpriteRenderer frontBackground;
    [SerializeField] private Sprite open;
    [SerializeField] private GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (SignPassword.signPass == "foxy" || SignPassword.signPass == "Foxy" || SignPassword.signPass == "FOXY"){
            FoxTime.Fpuzzle1Time = FoxTime.foxTimeSec;
            Debug.Log(SignPassword.signPass);
            goCaveInside.gateLock = false;
            frontBackground.sprite = open;
        }
        else{
            Debug.Log("failed");
        }
        cont.GetComponent<FoxCont>().signEnterDialogue();
    }
}
