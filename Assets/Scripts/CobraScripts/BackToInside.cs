using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToInside : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    private Vector2 inside = new Vector2 (0, -11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Camera.transform.position = inside;
    }
}
