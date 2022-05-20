using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStatueCobra : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    private bool statueDoorLocked = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (statueDoorLocked){
            cont.GetComponent<CobraContinue>().whenStatueDoorClicked();
        }
        else{
            Debug.Log("teehee nothing for now");
        }
    }
}
