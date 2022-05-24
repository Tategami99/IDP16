using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorsFront : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject RightArrow;
    Vector2 left = new Vector2 (-18, 0);
    [SerializeField]  private GameObject wall;
    [SerializeField]  private GameObject label;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        label.SetActive(false);
        wall.SetActive(false);
        GoDoorsHouse.EnteredFromDoorsHouse = false;
        Camera.transform.position = left;
        RightArrow.SetActive(true);
    }
}
