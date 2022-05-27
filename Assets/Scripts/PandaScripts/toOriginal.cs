using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toOriginal : MonoBehaviour
{
    [SerializeField] private GameObject Camera, left, right, self;
    private Vector2 original = new Vector2 (0, 0);
    // Start is called before the first frame update
    void Start()
    {
        left.SetActive(false);
        right.SetActive(false);
        self.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = original;
        left.SetActive(true);
        right.SetActive(true);
    }
}
