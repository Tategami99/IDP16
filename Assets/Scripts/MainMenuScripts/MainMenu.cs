using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject errorMessage;
    public static bool leaderUnlocked = true;
    public void PlayGame()
    {
        SceneManager.LoadScene(1); // loads the panda level
    }

    public void QuitGame()
    {
        Application.Quit();
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
