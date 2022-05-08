using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLeft : MonoBehaviour
{
    public GameObject Camera;
    Vector2 startPos = new Vector2 (0, 0);
    Vector2 Left = new Vector2 (-18 , 0);

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        Debug.Log("clicked");
        if (MoveRight.PandaArea == 0){
            Camera.transform.position = Left;
            MoveRight.PandaArea -= 1;
            
        }
        if (MoveRight.PandaArea == 1){
            Camera.transform.position = startPos;
            MoveRight.PandaArea -= 1;
            
        }
        
    }
}
