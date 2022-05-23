using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRainforest : MonoBehaviour
{
    [SerializeField] private GameObject mapView;
    [SerializeField] private GameObject rainforestHighlight;
    [SerializeField] private GameObject cont;
    private int firsttime = 0;
    [SerializeField] private GameObject Camera;
    Vector2 Rainforest = new Vector2 (18, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (firsttime != 0 && ToStatue.playerLocation != 2){
            Camera.transform.position = Rainforest;
            ToStatue.playerLocation = 2;
            mapView.SetActive(false);
        }
        else if (firsttime == 0 && ToStatue.playerLocation != 2){
            Camera.transform.position = Rainforest;
            ToStatue.playerLocation = 2;
            cont.GetComponent<CobraContinue>().enterRainforest();
            firsttime += 1;
            rainforestHighlight.SetActive(false);
            mapView.SetActive(false);
        }
    }
}
