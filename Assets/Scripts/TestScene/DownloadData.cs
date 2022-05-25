using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DownloadData : MonoBehaviour
{
    private System.Action<string> e;
    public static string sheetID = "17WWL4STELocGJoKzeZTT1EbNCnp1gD3Y4WFBUS1u9go";
    public static string sheetURL = "https://docs.google.com/spreadsheets/d/" + sheetID + "/export?format=csv";

    static IEnumerator downloadData(System.Action<string> onCompleted){
        yield return new WaitForEndOfFrame();

        string data = null;
        using (UnityWebRequest webReqest = UnityWebRequest.Get(sheetURL)){
            yield return webReqest.SendWebRequest();
        }
        onCompleted(data);
        Debug.Log(data);
    }
    public void startDownload(){
        StartCoroutine(downloadData(e));
    }
    
}
