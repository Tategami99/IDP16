
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad6 : MonoBehaviour
{
    [SerializeField] private TMP_Text caseCodedepotleft;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Keypad1.StorehousePasscode += "6";
        Debug.Log(Keypad1.StorehousePasscode);
        caseCodedepotleft.text += "6";
    }
}