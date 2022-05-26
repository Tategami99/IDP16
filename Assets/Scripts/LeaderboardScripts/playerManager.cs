using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;

public class playerManager : MonoBehaviour
{
    private string memberID = Username.username;
    public Leaderboard leaderboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator SetUpRoutine(){
        yield return LoginRoutine();
        yield return leaderboard.fetchHighScores();
    }

    IEnumerator LoginRoutine(){
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response)=>{
            if (response.success){
                Debug.Log("Player was logged in");
                PlayerPrefs.SetString("PlayerID", memberID);
                done = true;
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
