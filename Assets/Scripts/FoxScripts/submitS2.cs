using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitS2 : MonoBehaviour
{
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
        if (statuePasswords.s2pass == "howl" || statuePasswords.s2pass == "Howl" || statuePasswords.s2pass == "HOWL"){
            Debug.Log("correct");
            statuePasswords.numCorrect += 1;
            cont.GetComponent<FoxCont>().foxEnterDialogue();
        }
    }
}
