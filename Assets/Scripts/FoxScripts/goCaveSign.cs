using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goCaveSign : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    private Vector2 sign = new Vector2 (-18, 11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = sign;
    }
}