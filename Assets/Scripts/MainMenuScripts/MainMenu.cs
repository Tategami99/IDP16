using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject errorMessage, opening;
    public static bool leaderUnlocked = true;
    public static bool played = false;
    public void PlayGame()
    {
        played = true;
        opening.SetActive(true);
        fadeOut.fadeMainOut = true; 
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void LeaderboardGame(){
        if (leaderUnlocked){
            SceneManager.LoadScene("Leaderboard");
        }
        else{
            StartCoroutine(callError());
        }
    }

    IEnumerator callError(){
        errorMessage.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        errorMessage.SetActive(false);
    }
}
