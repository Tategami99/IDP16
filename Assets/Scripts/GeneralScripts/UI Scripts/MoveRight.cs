using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject left;
    public GameObject Camera;
    Vector2 startPos = new Vector2 (0, 0);
    Vector2 Right = new Vector2 (18 , 0);
    public static int PandaArea;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        PandaArea = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        Debug.Log("clicked");
        if (PandaArea == 0){
            Camera.transform.position = Right;
            PandaArea = PandaArea + 1;
            self.SetActive(false);
            
        }
        if (PandaArea == -1){
            Camera.transform.position = startPos;
            PandaArea = PandaArea + 1;
            left.SetActive(true);
        }
        
    }
}