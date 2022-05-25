using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SendToGoogle : MonoBehaviour
{
    public static int TotalTimeInt;
    private string usernameData;
    private string totalTimeData;
    private string pandaTimeData;
    private string cobraTimeData;
    private string foxTimeData;
    [SerializeField] private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSejNerHnQXybWlzSdexKIFLAGkBoeoTfX7I78LbmY9WDMF1cQ/formResponse";

    IEnumerator Post(string nameData, string totalData, string pandaData, string cobraData, string foxData){
        WWWForm form = new WWWForm();
        form.AddField("entry.467118400", nameData);
        form.AddField("entry.1677874481", totalData);
        form.AddField("entry.1779163284", pandaData);
        form.AddField("entry.595491149", cobraData);
        form.AddField("entry.1554875559", foxData);
        UnityWebRequest www = UnityWebRequest.Post(BASE_URL, form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success){
            Debug.Log(www.error);
        }
        else{
            Debug.Log("complete");
        }
    }

    public void Send(){
        usernameData = Username.username;
        TotalTimeInt = PandaTime.pandaTimeSec + CobraTime.cobraTimeSec + FoxTime.foxTimeSec;
        totalTimeData = TotalTimeInt.ToString();
        pandaTimeData = PandaTime.pandaTimeSec.ToString();
        cobraTimeData = CobraTime.cobraTimeSec.ToString();
        foxTimeData = FoxTime.foxTimeSec.ToString();

        StartCoroutine(Post(usernameData, totalTimeData, pandaTimeData, cobraTimeData, foxTimeData));
    }
    /*
    WWWForm form = new WWWForm();
        form.AddField("entry.467118400", nameData);
        form.AddField("entry.1677874481", totalData);
        form.AddField("entry.1779163284", pandaData);
        form.AddField("entry.595491149", cobraData);
        form.AddField("entry.1554875559", foxData);
        byte[] rawData = form.data;
    */

    /*
    List<IMultipartFormSection> form = new List<IMultipartFormSection>;
        form.Add(new MultipartFormDataSection("entry.467118400", nameData));
        form.Add(new MultipartFormDataSection("entry.1677874481", nameData));
        form.Add(new MultipartFormDataSection("entry.1779163284", nameData));
        form.Add(new MultipartFormDataSection("entry.595491149", nameData));
        form.Add(new MultipartFormDataSection("entry.1554875559", nameData));
    */
}
