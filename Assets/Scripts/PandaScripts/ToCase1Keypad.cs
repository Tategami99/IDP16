using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCase1Keypad : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 case1KeypadView = new Vector2 (36, 11);
    public static bool enteredFromcase1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = case1KeypadView;
        enteredFromcase1 = true;
    }
}
