using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEscape : MonoBehaviour
{
    [SerializeField] private GameObject leave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (fragment1case.case1unlocked){
            leave.SetActive(false);
        }
    }
}
