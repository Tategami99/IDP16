using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMap : MonoBehaviour
{
    [SerializeField] private GameObject mapView;
    public static int mapLocation = 0;
    [SerializeField] private GameObject self;
    [SerializeField] private GameObject slot1;
    [SerializeField] private GameObject slot2;
    [SerializeField] private GameObject slot3;
    [SerializeField] private GameObject slot4;
    [SerializeField] private GameObject slot5;
    public static bool mapAdded = false;
    // Start is called before the first frame update
    void Start()
    {
        mapView.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown() {
        mapLocation = 1;
        mapAdded = true;
        Debug.Log("ml= " + mapLocation);
        self.SetActive(false);
    }
}
