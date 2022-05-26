using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoxTime : MonoBehaviour
{
    [SerializeField] private TMP_Text TimerText;
    public static float totalTimeLeft = 1800;
    public static int foxTimeSec = 0;
    private int nextUpdate = 1;
    public static int Fpuzzle1Time;
    public static int Fpuzzle2Time;
    public static int Fpuzzle3Time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextUpdate){
            Debug.Log(Time.time + ">= Fox " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.timeSinceLevelLoad) + 1;
            everyFsecond();
            updateTimer();
        }
    }
    void everyFsecond(){
        foxTimeSec += 1;
        totalTimeLeft -= 1;
    }
    void updateTimer(){
        float minutes = Mathf.FloorToInt(((totalTimeLeft - PandaTime.pandaTimeSec - CobraTime.cobraTimeSec) / 60) % 60);
        float seconds = Mathf.FloorToInt((totalTimeLeft - PandaTime.pandaTimeSec - CobraTime.cobraTimeSec) % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
