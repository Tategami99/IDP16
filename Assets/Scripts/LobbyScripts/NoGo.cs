using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGo : MonoBehaviour
{
    public GameObject Dialogue;
    static int ContTimeSec;
    private int nextUpdate = 1;
    private int recordClick;
    // Start is called before the first frame update
    void Start()
    {
        Dialogue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate){
            Debug.Log(Time.time + ">= Cont " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            ContTimeSec += 1;
        }
        if (recordClick + 5 == ContTimeSec){
            Dialogue.SetActive(false);
        }
    }
    public void clicky() {
        Dialogue.SetActive(true);
        recordClick = ContTimeSec;
    }
}
