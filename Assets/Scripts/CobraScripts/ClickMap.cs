using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMap : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    private int firsttime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (firsttime == 0){
            GetComponent<UseMap>().useIt();
            GetComponent<UseMap>().openMap();
            firsttime += 1;
        }
        else{
            GetComponent<UseMap>().openMap();
        }
    }
}
