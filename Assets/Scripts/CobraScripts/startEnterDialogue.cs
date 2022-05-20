using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startEnterDialogue : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
        cont.GetComponent<CobraContinue>().firstEnterCobra();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
