using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSword : MonoBehaviour
{
    public static bool swordObtained = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        swordObtained = true;
    }
}
