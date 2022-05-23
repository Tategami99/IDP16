using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopToBase : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    private Vector2 mountainBase = new Vector2 (0, -11);
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
        Camera.transform.position = mountainBase;
    }
}
