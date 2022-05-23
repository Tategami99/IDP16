using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackOutside : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 outside = new Vector2 (0, 0);
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
        Camera.transform.position = outside;
    }
}
