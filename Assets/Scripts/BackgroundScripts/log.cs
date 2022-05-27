using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<playerManager>().startLogin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
