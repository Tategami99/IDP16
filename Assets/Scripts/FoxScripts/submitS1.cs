using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitS1 : MonoBehaviour
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
        if (statuePasswords.s1pass == "arctic fox" || statuePasswords.s1pass == "Arctic Fox" || statuePasswords.s1pass == "ARCTIC Fox"){
            Debug.Log("correct");
            statuePasswords.numCorrect += 1;
            cont.GetComponent<FoxCont>().foxEnterDialogue();
        }
    }
}
