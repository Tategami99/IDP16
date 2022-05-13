using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIalogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BackgroundTextWrite>().Run(textToType:"You are a criminal that has been hired to find and recover the infamous Phoenix artifact from the Museum of CAMS.", textLabel);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
