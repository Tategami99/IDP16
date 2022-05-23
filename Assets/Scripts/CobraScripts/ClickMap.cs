using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMap : MonoBehaviour
{
    [SerializeField] private GameObject mapView;
    [SerializeField] private GameObject cont;
    private bool firsttime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (AddMap.mapAdded){
            mapView.SetActive(true);
            if (firsttime){
                cont.GetComponent<CobraContinue>().mapClicked();
                firsttime = false;
            }
        }
        Debug.Log("clicked");
    }
}
