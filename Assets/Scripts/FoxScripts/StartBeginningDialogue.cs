using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBeginningDialogue : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
       cont.GetComponent<FoxCont>().firstEnterFox(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
