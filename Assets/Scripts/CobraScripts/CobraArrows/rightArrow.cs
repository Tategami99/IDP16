using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rightArrow : MonoBehaviour
{
    [SerializeField] private GameObject up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        upArrow.xC += 1;
        up.GetComponent<upArrow>().checkSolved();
    }
}