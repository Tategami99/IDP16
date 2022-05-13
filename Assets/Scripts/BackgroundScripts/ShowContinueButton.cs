using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowContinueButton : MonoBehaviour
{
    static int ContTimeSec;
    private int nextUpdate = 1;
    public GameObject ContButton;
    // Start is called before the first frame update
    void Start()
    {
        ContButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate){
            Debug.Log(Time.time + ">= Cont " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            everyPsecond();
        }
    }
    void everyPsecond(){
        ContTimeSec += 1;
        if (ContTimeSec == 20){
            ContButton.SetActive(true);
        }
    }
}