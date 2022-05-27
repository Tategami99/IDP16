using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableStorehouse : MonoBehaviour
{
    [SerializeField] private GameObject storeHandle, doorHandle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        storeHandle.SetActive(false);
        doorHandle.SetActive(false);
    }
}
