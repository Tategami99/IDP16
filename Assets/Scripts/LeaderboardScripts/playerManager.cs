/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;

public class playerManager : MonoBehaviour
{
    public Leaderboard leaderboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator SetUpRoutine(){
        yield return LoginRoutine();
    }
    IEnumerator scoreRoutine(){
        yield return leaderboard.fetchHighScores();
    }

    IEnumerator LoginRoutine(){
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response)=>{
            if (response.success){
                Debug.Log("Player was logged in");
                PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
                GetComponent<toAgent>().beginning();
            }
            else{
                Debug.Log("could not start session");
                bool done = true;
            }

        });
        yield return new WaitWhile(()=>done == false);
    }

    public void startLogin(){
        StartCoroutine(SetUpRoutine());
    }
    public void scoreFetch(){
        StartCoroutine(scoreRoutine());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
*/