using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtainMap : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        cont.GetComponent<CobraContinue>().mapObtained();
    }
}
