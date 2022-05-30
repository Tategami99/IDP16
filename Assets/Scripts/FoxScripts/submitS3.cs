using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitS3 : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    private bool firsttime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (firsttime){
            if (statuePasswords.s3pass == "echo" || statuePasswords.s3pass == "ECHO" || statuePasswords.s3pass == "Echo"){
                Debug.Log("correct");
                statuePasswords.numCorrect += 1;
                firsttime = false;
                cont.GetComponent<FoxCont>().foxEnterDialogue();
                FoxTime.Fpuzzle3Time = FoxTime.foxTimeSec - FoxTime.Fpuzzle2Time;
        }
        }
    }
}
