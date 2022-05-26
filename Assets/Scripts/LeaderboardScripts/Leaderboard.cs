using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    int leaderboardID = 3237;
    public TextMeshProUGUI playerNames, playerScores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public IEnumerator submitScore(int scoreToUpload){
        bool done = false;
        string memberID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(memberID, scoreToUpload, leaderboardID,(response)=>{
            if (response.success){
                Debug.Log("upload score success");
                done = true;
            }
            else{
                Debug.Log("failed: " + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }
    public IEnumerator fetchHighScores(){
        bool done = false;
        LootLockerSDKManager.GetScoreListMain(leaderboardID, 5, 0, (response)=>{
            if (response.success){
                string tempPlayerNames = "Agent\n";
                string tempPlayerScores = "Time\n";
                LootLockerLeaderboardMember[] members = response.items;
                for (int i = 0; i < members.Length; i++){
                    tempPlayerNames += members[i].rank + ". ";
                    if (members[i].player.name != ""){
                        tempPlayerNames += members[i].player.name;
                    }
                    else{
                        tempPlayerNames += members[i].player.id;
                    }
                    tempPlayerScores += members[i].score + "\n";
                    tempPlayerNames += "\n";
                }
                done = true;
                playerNames.text = tempPlayerNames;
                playerScores.text = tempPlayerScores;
            }
            else{
                Debug.Log("failed" + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(()=> done == false);
    }
}
