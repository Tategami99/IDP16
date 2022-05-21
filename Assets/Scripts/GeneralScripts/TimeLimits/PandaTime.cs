using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaTime : MonoBehaviour
{
    static int pandaTimeSec;
    private int nextUpdate = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate){
            Debug.Log(Time.time + ">= Panda " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            everyPsecond();
        }
    }
    void everyPsecond(){
        pandaTimeSec += 1;
    }
}
