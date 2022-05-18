using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMagniScreen : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 tinyMark = new Vector2 (36, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = tinyMark;
    }
}
