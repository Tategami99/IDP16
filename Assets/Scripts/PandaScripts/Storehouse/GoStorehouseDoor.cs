using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoStorehouseDoor : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject LeftArrow;
    [SerializeField] private GameObject RightArrow;
    Vector2 door = new Vector2 (0, 11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        Debug.Log("clicked");
        Camera.transform.position = door;
        LeftArrow.SetActive(false);
        RightArrow.SetActive(false);
    }
}
