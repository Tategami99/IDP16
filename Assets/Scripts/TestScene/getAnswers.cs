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
    public static string experience;
    public static string entertaining;
    public static string difficult;
    public static string improve;
    public static string issues;
    public static string mood;
    [SerializeField] private GameObject selected;
    
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
    }
    public void iss(string ues){
        issues = ues;
        Debug.Log(issues);
    }
    public void moo(string ood){
        mood = ood;
        Debug.Log(mood);
    }
    public void one(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (-3, 0, 5);
        experience = "1";
    }
    public void two(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (-1.5f, 0, 5);
        experience = "2";
    }
    public void three(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (0, 0, 5);
        experience = "3";
    }
    public void four(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (1.5f, 0, 5);
        experience = "4";
    }
    public void five(){
        selected.SetActive(true);
        selected.transform.position = new Vector3 (3, 0, 0);
        experience = "5";
    }
    public void enteP(){
        entertaining = "Panda Exhibit";
    }
    public void enteC(){
        entertaining = "Cobra Exhibit";
    }
    public void enteF(){
        entertaining = "Fox Exhibit";
    }
    public void difP(){
        difficult = "Panda Exhibit";
    }
    public void difC(){
        difficult = "Cobra Exhibit";
    }
    public void difF(){
        difficult = "Fox Exhibit";
    }
}
