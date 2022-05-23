using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainforestToBack : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 rainforest = new Vector2 (18, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = rainforest;
    }
}
