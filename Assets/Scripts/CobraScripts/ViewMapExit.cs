using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMapExit : MonoBehaviour
{
    [SerializeField] private GameObject mapView;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        mapView.SetActive(false);
    }
}
