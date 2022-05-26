/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class readerJSON : MonoBehaviour
{
    private string jsonString;
    IEnumerator ObtainSheetData(){
        UnityWebRequest www = UnityWebRequest.Get("https://sheets.googleapis.com/v4/spreadsheets/17WWL4STELocGJoKzeZTT1EbNCnp1gD3Y4WFBUS1u9go/values/Sheet2?key=AIzaSyBGbNZOVsnYAPAICVJ6ilw2J4AkBE2vN_s");
        yield return www.SendWebRequest();
        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError){
            Debug.Log(("Error: " + www.error));
        }
        else{
            jsonString = www.downloadHandler.text;
            Debug.Log(jsonString);
        }
    }
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
        StartCoroutine(ObtainSheetData());
        myPlayerList = JsonUtility.FromJson<PlayerList>(jsonString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/