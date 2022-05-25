using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPenalty : MonoBehaviour
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
        FoxTime.totalTimeLeft -= 10;
        FoxTime.foxTimeSec += 10;
        cont.GetComponent<FoxCont>().penaltyDialogue();
    }
}
