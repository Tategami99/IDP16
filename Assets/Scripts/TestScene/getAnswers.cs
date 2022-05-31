using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAnswers : MonoBehaviour
{
    private int index = 0;
    [SerializeField] private GameObject leftArrow;
    [SerializeField] private GameObject rightArrow;
    [SerializeField] private GameObject submit;
    [SerializeField] private List<GameObject> questions = new List<GameObject>();
    public static string experience = "";
    public static string entertaining = "";
    public static string difficult = "";
    public static string improve = "";
    public static string issues = "";
    public static string mood = "";
    [SerializeField] private GameObject selected, selected2, selected3;
    public static bool answered = false, answered2 = false, answered3 = false, answered4 = false, answered5 = false, answered6 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        leftArrow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void next(){
        if (index == 4){
            rightArrow.SetActive(false);
            submit.SetActive(true);
        }
        if (index == 0){
            leftArrow.SetActive(true);
        }
        if (index > -1 && index < 5){
            questions[index].SetActive(false);
            questions[index + 1].SetActive(true);
            index += 1;
        }
    }
    public void back(){
        if (index == 5){
            rightArrow.SetActive(true);
            submit.SetActive(false);
        }
        if (index == 1){
            leftArrow.SetActive(false);
        }
        if (index > 0 && index < 6){
            questions[index].SetActive(false);
            questions[index - 1].SetActive(true);
            index -= 1;
        }
    }
    public void imp(string ove){
        improve = ove;
        Debug.Log(improve);
        checkq4();
    }
    public void iss(string ues){
        issues = ues;
        Debug.Log(issues);
        checkq5();
    }
    public void moo(string ood){
        mood = ood;
        Debug.Log(mood);
        checkq6();
    }
    public void one(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (-3, 0, 5);
        experience = "1";
        checkq1();
    }
    public void two(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (-1.5f, 0, 5);
        experience = "2";
        checkq1();
    }
    public void three(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (0, 0, 5);
        experience = "3";
        checkq1();
    }
    public void four(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (1.5f, 0, 5);
        experience = "4";
        checkq1();
    }
    public void five(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (3, 0, 5);
        experience = "5";
        checkq1();
    }
    public void enteP(){
        entertaining = "Panda Exhibit";
        selected2.SetActive(true);
        selected2.transform.position = new Vector3(0, 1, 5);
        checkq2();
    }
    public void enteC(){
        entertaining = "Cobra Exhibit";
        selected2.SetActive(true);
        selected2.transform.position = new Vector3(0, -0.5f, 5);
        checkq2();
    }
    public void enteF(){
        entertaining = "Fox Exhibit";
        selected2.SetActive(true);
        selected2.transform.position = new Vector3(0, -2, 5);
        checkq2();
    }
    public void difP(){
        difficult = "Panda Exhibit";
        selected3.SetActive(true);
        selected3.transform.position = new Vector3(0, 1, 5);
        checkq3();
    }
    public void difC(){
        difficult = "Cobra Exhibit";
        selected3.SetActive(true);
        selected3.transform.position = new Vector3(0, -0.5f, 5);
        checkq3();
    }
    public void difF(){
        difficult = "Fox Exhibit";
        selected3.SetActive(true);
        selected3.transform.position = new Vector3(0, -2, 5);
        checkq3();
    }
    private void checkq1(){
        if (experience != ""){
            answered = true;
        }
        else{
            answered = false;
        }
    }
    private void checkq2(){
        if (entertaining != ""){
            answered2 = true;
        }
        else{
            answered2 = false;
        }
    }
    private void checkq3(){
        if (difficult != ""){
            answered3 = true;
        }
        else{
            answered3 = false;
        }
    }
    private void checkq4(){
        if (improve != ""){
            answered4 = true;
        }
        else{
            answered4 = false;
        }
    }
    private void checkq5(){
        if (issues != ""){
            answered5 = true;
        }
        else{
            answered5 = false;
        }
    }
    private void checkq6(){
        if (mood != ""){
            answered6 = true;
        }
        else{
            answered6 = false;
        }
    }
}
