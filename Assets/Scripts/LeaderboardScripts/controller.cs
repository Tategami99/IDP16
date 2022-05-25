using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LootLocker.Requests;

public class controller : MonoBehaviour
{
    public InputField MemberID, PlayerScore;
    public int ID;

    private void Start(){
        LootLockerSDKManager.StartSession(Username.username, (response) =>{
            if (response.success){
                Debug.Log("success");
            }
            else{
                Debug.Log("failed")
            }
        });
    }
    public void submitScore(){
        LootLockerSDKManager.SubmitScore(MemberID.text, (response)
    }
}
