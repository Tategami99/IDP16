using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitLeaderboard : MonoBehaviour
{
    public Leaderboard leaderboard;
    private int total;
    // Start is called before the first frame update
    void Start()
    {
        if (PandaTime.pandaTimeSec > 0){
            total = PandaTime.pandaTimeSec + CobraTime.cobraTimeSec + FoxTime.foxTimeSec;
        }
        else{
            total = 1800;
        }
        if (MainMenu.played){
            StartCoroutine(callLead());
            Debug.Log("submitted");
        }
        else{
            Debug.Log("not submitted");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator callLead(){
        yield return new WaitForSecondsRealtime(1);
        yield return leaderboard.submitScore(total);
    }
}
