using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goCaveInside : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject cont;
    private Vector2 inside = new Vector2 (18, 0);
    public static bool gateLock = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (gateLock){
            cont.GetComponent<FoxCont>().gateLockedDialogue();
        }
        else{
            Camera.transform.position = inside;
        }
    }
}
