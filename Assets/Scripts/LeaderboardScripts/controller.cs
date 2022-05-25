/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;

public class controller : MonoBehaviour
{
    
    private string PlayerName = Username.username;
    private int Score = PandaTime.pandaTimeSec + CobraTime.cobraTimeSec + FoxTime.foxTimeSec;
    public int ID;

    private void Start(){
        StartCoroutine(LoginRoutine());
    }
    
    IEnumerator LoginRoutine(){
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>{
            if (response.success){
                Debug.Log("yay");
                PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
            }
            else{
                Debug.Log("boo");
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }
}
*/
