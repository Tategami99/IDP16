using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitLeaderboard : MonoBehaviour
{
    public Leaderboard leaderboard;
    private int total = PandaTime.pandaTimeSec + CobraTime.cobraTimeSec + FoxTime.foxTimeSec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        StartCoroutine(callLead());
    }
    IEnumerator callLead(){
        yield return new WaitForSecondsRealtime(1);
        yield return leaderboard.submitScore(total);
    }
}
