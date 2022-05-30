using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CobraTime : MonoBehaviour
{
    [SerializeField] private TMP_Text TimerText;
    public static float totalTimeLeft = 1800;
    public static int cobraTimeSec = 0;
    private int nextUpdate = 1;
    public static int Cpuzzle1Time = 0;
    public static int Cpuzzle2Time = 0;
    public static int Cpuzzle3Time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= nextUpdate){
            Debug.Log(Time.time + ">= Cobra " + nextUpdate);
            nextUpdate = Mathf.FloorToInt(Time.timeSinceLevelLoad) + 1;
            everyCsecond();
            updateTimer();
            if (totalTimeLeft == 0){
                SceneManager.LoadScene("LoseScreen");
            }
        }
        if (totalTimeLeft == 0){
                SceneManager.LoadScene("LoseScreen");
        }
    }
    void everyCsecond(){
        cobraTimeSec += 1;
        totalTimeLeft -= 1;
    }
    void updateTimer(){
        float minutes = Mathf.FloorToInt(((totalTimeLeft - PandaTime.pandaTimeSec) / 60) % 60);
        float seconds = Mathf.FloorToInt((totalTimeLeft - PandaTime.pandaTimeSec) % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
