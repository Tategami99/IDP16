using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class OMG : MonoBehaviour
{
    public TMP_Text outputArea;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObtainSheetData());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ObtainSheetData(){
        UnityWebRequest www = UnityWebRequest.Get("https://sheets.googleapis.com/v4/spreadsheets/17WWL4STELocGJoKzeZTT1EbNCnp1gD3Y4WFBUS1u9go/values/Sheet2?key=AIzaSyBGbNZOVsnYAPAICVJ6ilw2J4AkBE2vN_s");
        yield return www.SendWebRequest();
        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError){
            Debug.Log("Error:" + www.error);
        }
        else{
            string json = www.downloadHandler.text;
            Debug.Log(json);
        }
    }
}
