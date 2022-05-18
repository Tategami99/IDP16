using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBase : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 mountainBase = new Vector2 (0, -11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = mountainBase;
    }
}
