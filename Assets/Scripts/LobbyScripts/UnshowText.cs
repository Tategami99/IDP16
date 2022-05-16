using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnshowText : MonoBehaviour
{
    [SerializeField] private GameObject Dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Dialogue.SetActive(false);
    }
}
