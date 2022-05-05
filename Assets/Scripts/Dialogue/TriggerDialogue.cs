using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public EntranceDialogue dialogue;

    public void Trigger(){
        FindObjectOfType<PoliceAreComing>().StartDialogue(dialogue);
    }
}
