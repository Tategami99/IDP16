using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceAreComing : MonoBehaviour
{
    private Queue<string> Dialogue;

    // Start is called before the first frame update
    void Start()
    {
        Dialogue = new Queue<string>();
    }

    public void StartDialogue(EntranceDialogue dialogue){
        Debug.Log("Starting conversation with" + dialogue.name);
    }
}
