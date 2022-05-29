using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMap : MonoBehaviour
{
    [SerializeField] private GameObject mapView;
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject inventory, x, highlight;
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
                inventory.SetActive(false);
                x.SetActive(false);
                firsttime = false;
                highlight.SetActive(false);
            }
        }
        Debug.Log("clicked");
    }
}
