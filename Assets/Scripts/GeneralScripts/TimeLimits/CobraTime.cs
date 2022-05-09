using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobraTime : MonoBehaviour
{
    static int CobraTimeSec;
    private int nextUpdate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate){
            Debug.Log(Time.time + ">= Cobra " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            everyCsecond();
        }
    }
    void everyCsecond(){
        CobraTimeSec += 1;
    }
}
