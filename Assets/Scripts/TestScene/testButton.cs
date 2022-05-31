using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testButton : MonoBehaviour
{
    [SerializeField] private GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator wait(){
        yield return new WaitForSecondsRealtime(1);
        sprite.SetActive(false);
    }
    private void OnMouseDown() {
        if (getAnswers.answered && getAnswers.answered2 && getAnswers.answered3 && getAnswers.answered4 && getAnswers.answered5 && getAnswers.answered6){
            GetComponent<SendToGoogle>().Send();
            MainMenu.leaderUnlocked = true;
            SceneManager.LoadScene("Leaderboard");
        }
        else{
            sprite.SetActive(true);
            StartCoroutine(wait());
        }
    }
}
