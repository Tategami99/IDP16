using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDoorsHouse : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject LeftArrow;
    [SerializeField] private GameObject RightArrow;
    Vector2 door = new Vector2 (-18, 11);
    public static bool EnteredFromDoorsHouse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        EnteredFromDoorsHouse = true;
        Debug.Log("clicked");
        Camera.transform.position = door;
        LeftArrow.SetActive(false);
        RightArrow.SetActive(false);
    }
}

