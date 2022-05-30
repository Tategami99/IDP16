using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cEnterKey : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject Camera;
    Vector2 inside = new Vector2 (0, -11);
    [SerializeField] private SpriteRenderer insideBackground;
    [SerializeField] private Sprite insideWithFragment;
    [SerializeField] private GameObject keypad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (c9key.cobraStatueCode == "9"){
            CobraTime.Cpuzzle3Time = CobraTime.cobraTimeSec - CobraTime.Cpuzzle2Time - CobraTime.Cpuzzle1Time;
            Debug.Log(CobraTime.Cpuzzle3Time + "-3");
            keypad.SetActive(false);
            CobraTime.Cpuzzle3Time = CobraTime.cobraTimeSec;
            Debug.Log("unlocked");
            insideBackground.sprite = insideWithFragment;
            Camera.transform.position = inside;
            cont.GetComponent<CobraContinue>().codeCorrect();
        }
        else{
            cont.GetComponent<CobraContinue>().codeWrong();
        }
    }
}
