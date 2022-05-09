using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalTime : MonoBehaviour
{
    static int totalTimeSec;
    private int nextUpdate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextUpdate){
            Debug.Log(Time.time + ">=" + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            everySecond();
        }
    }

    void everySecond(){
        totalTimeSec += 1;
    }
}
