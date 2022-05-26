using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SendToGoogle : MonoBehaviour
{
    public static int TotalTimeInt;
    private string usernameData;
    private string totalTimeData;
    private string pandaTimeData;
    private string cobraTimeData;
    private string foxTimeData;
    [SerializeField] private GameObject question1, question2, question3, question4, question5, question6;
    private string q1, q2, q3, q4, q5, q6;
    [SerializeField] private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSejNerHnQXybWlzSdexKIFLAGkBoeoTfX7I78LbmY9WDMF1cQ/formResponse";

    IEnumerator Post(string nameData, string totalData, string pandaData, string cobraData, string foxData, string ques1, string ques2, string ques3, string ques4, string ques5, string ques6){
        WWWForm form = new WWWForm();
        form.AddField("entry.467118400", nameData);
        form.AddField("entry.1677874481", totalData);
        form.AddField("entry.1779163284", pandaData);
        form.AddField("entry.595491149", cobraData);
        form.AddField("entry.1554875559", foxData);
        form.AddField("entry.2125946185", ques1);
        form.AddField("entry.1412969754", ques2);
        form.AddField("entry.1450572400", ques3);
        form.AddField("entry.244538232", ques4);
        form.AddField("entry.1102387264", ques5);
        form.AddField("entry.336416648", ques6);
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
        q1 = getAnswers.experience;
        q2 = getAnswers.entertaining;
        q3 = getAnswers.difficult;
        q4 = getAnswers.improve;
        q5 = getAnswers.issues;
        q6 = getAnswers.mood;

        StartCoroutine(Post(usernameData, totalTimeData, pandaTimeData, cobraTimeData, foxTimeData, q1, q2, q3, q4, q5, q6));
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
