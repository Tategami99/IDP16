using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class readerJSON : MonoBehaviour
{
    IEnumerator ObtainSheetData()
    [System.Serializable]
    public class data{
        public string Username;
        public string TotalTime;
    }

    [System.Serializable]
    public class PlayerList{
        public data[] values;
    }

    public PlayerList myPlayerList = new PlayerList();
    // Start is called before the first frame update
    void Start()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSon.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}