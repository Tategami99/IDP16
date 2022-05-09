using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxTime : MonoBehaviour
{
    static int FoxTimeSec;
    private int nextUpdate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate){
            Debug.Log(Time.time + ">= Fox " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            everyFsecond();
        }
    }
    void everyFsecond(){
        FoxTimeSec += 1;
    }
}
