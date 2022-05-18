using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMountainBase : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject Gate;
    Vector2 mountainBase = new Vector2 (0, -11);
    // Start is called before the first frame update
    void Start()
    {
        Gate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        Camera.transform.position = mountainBase;
        Debug.Log("worked");
    }
}
