using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStatueCobra : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject cont;
    public static bool statueDoorLocked = true;
    Vector2 insideStatue = new Vector2 (0, -11);
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
            Camera.transform.position = insideStatue;
            penalizeCobra.playerLocation = "formula";
        }
    }
}
