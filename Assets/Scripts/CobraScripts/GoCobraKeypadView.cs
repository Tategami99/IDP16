using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoCobraKeypadView : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 keypad = new Vector2 (0, -22);
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
        Camera.transform.position = keypad;
    }
}
