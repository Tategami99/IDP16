using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTop : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 mountainTop = new Vector2 (36, -11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        top();
    }
    public void top(){
        Camera.transform.position = mountainTop;
    }
}
