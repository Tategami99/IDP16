/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class toAgent : MonoBehaviour
{
    [SerializeField] private TMP_Text sender;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<playerManager>().startLogin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void beginning(){
        string agentNum = PlayerPrefs.GetString("PlayerID");
        sender.text = "To agent " + agentNum + ":";
    }
}
*/