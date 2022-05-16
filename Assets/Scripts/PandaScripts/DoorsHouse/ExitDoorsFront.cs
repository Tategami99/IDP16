using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorsFront : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject LeftArrow;
    [SerializeField] private GameObject RightArrow;
    Vector2 left = new Vector2 (-18, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        GoDoorsHouse.EnteredFromDoorsHouse = false;
        Camera.transform.position = left;
        LeftArrow.SetActive(true);
        RightArrow.SetActive(true);
    }
}
