using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showLeaderboard : MonoBehaviour
{
    [SerializeField] private TMP_Text playerAgentNum;
    [SerializeField] private GameObject area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        area.SetActive(false);
        GetComponent<playerManager>().scoreFetch();
        Debug.Log(PandaTime.pandaTimeSec);
        area.SetActive(true);
        playerAgentNum.text = PlayerPrefs.GetString("PlayerID");
    }
    
}
