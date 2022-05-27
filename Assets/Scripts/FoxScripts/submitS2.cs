using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitS2 : MonoBehaviour
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
            if (statuePasswords.s2pass == "howl" || statuePasswords.s2pass == "Howl" || statuePasswords.s2pass == "HOWL"){
                Debug.Log("correct");
                statuePasswords.numCorrect += 1;
                firsttime = false;
                cont.GetComponent<FoxCont>().foxEnterDialogue();
        }
        }
    }
}
