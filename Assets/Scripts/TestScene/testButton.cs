using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        GetComponent<SendToGoogle>().Send();
        MainMenu.leaderUnlocked = true;
        SceneManager.LoadScene("Leaderboard");
    }
}
