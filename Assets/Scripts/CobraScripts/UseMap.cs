using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseMap : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject mapView;
    // Start is called before the first frame update
    void Start()
    {
        mapView.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void useIt() {
        cont.GetComponent<CobraContinue>().mapClicked();
    }

    public void openMap(){
        mapView.SetActive(true);
    }
}
