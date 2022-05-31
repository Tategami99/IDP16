using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class upArrow : MonoBehaviour
{
    [SerializeField] private TMP_Text coorLabel;
    [SerializeField] private SpriteRenderer fractionImage;
    [SerializeField] private Sprite Of13;
    [SerializeField] private Sprite Of23;
    [SerializeField] private Sprite Of33;
    [SerializeField] private GameObject cont;
    [SerializeField] private AudioSource arrowClick;
    public static int xC = 0;
    public static int yC = 0;
    public static int numSolved = 0;
    public static bool fsSolved = false;
    public static bool stSolved = false;
    public static bool feSolved = false;
    private bool firstMessageShown = false;
    private bool secondMessageShown = false;
    private bool thirdMessageShown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeFraction(){
        if (numSolved == 1){
            fractionImage.sprite = Of13;
        }
        else if (numSolved == 2){
            fractionImage.sprite = Of23;
        }
        else if (numSolved == 3){
            fractionImage.sprite = Of33;
        }
    }

    public void checkSolved(){
        arrowClick.Play();
        coorLabel.text = ("(" + xC.ToString() + "," + yC.ToString() + ")");
        if (xC == 5 && yC == 7 && fsSolved != true){
            fsSolved = true;
            numSolved += 1;
            changeFraction();
        }
        if (xC == -6 && yC == -10 && stSolved != true){
            stSolved = true;
            numSolved += 1;
            changeFraction();
        }
        if (xC == 4 && yC == -8 && feSolved != true){
            feSolved = true;
            numSolved += 1;
            changeFraction();
        }
        if (numSolved == 1 && firstMessageShown == false){
            firstMessageShown = true;
            cont.GetComponent<CobraContinue>().OofTDialogue();
        }
        if (numSolved == 2 && secondMessageShown == false){
            secondMessageShown = true;
            cont.GetComponent<CobraContinue>().TofTDialogue();
            CobraTime.Cpuzzle1Time = CobraTime.cobraTimeSec;
            Debug.Log(CobraTime.Cpuzzle1Time + "-1");
        }
        if (numSolved == 3 && thirdMessageShown == false){
            thirdMessageShown = true;
            cont.GetComponent<CobraContinue>().ThofTDialogue();
            CobraTime.Cpuzzle2Time = CobraTime.cobraTimeSec - CobraTime.Cpuzzle1Time;
            Debug.Log(CobraTime.Cpuzzle2Time + "-2");
        }
        Debug.Log("(" + xC + "," + yC + ")");
    }
    private void OnMouseDown() {
        yC += 1;
        checkSolved();
        if (numSolved == 3){
            DoorStatueCobra.statueDoorLocked = false;
        }
    }
}
