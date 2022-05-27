using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectFrag3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        detectFrag.frag1Selected = false;
        detectFrag2.frag2Selected = false;
        detectFrag3.frag3Selected = true;
    }
}
