using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startStartDialogue : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
        cont.GetComponent<PandaContinueButton>().startDialogue();
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
