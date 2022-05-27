using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFrag : MonoBehaviour
{
    public static bool movable = true;
    public static bool frag1Place = false;
    private Vector3 dragOffset;
    private void OnMouseDown() {
        dragOffset = transform.position - GetMousePos();
    }
    private void OnMouseDrag() {
        if (transform.position.x < 1.48 && transform.position.x > 1.10 && transform.position.y < 0.61 && transform.position.y > 0.49){
            movable = false;
            frag1Place = true;
            Debug.Log(movable);
        }
        if (movable){
            transform.position = GetMousePos() + dragOffset;
        }
    }
    Vector3 GetMousePos(){
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 10;
        return mousePos;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 1.48 && transform.position.x > 1.10 && transform.position.y < 0.61 && transform.position.y > 0.49){
            movable = false;
            frag1Place = true;
        }
    }
    private void OnMouseUp() {
        if (transform.position.x < 1.48 && transform.position.x > 1.10 && transform.position.y < 0.61 && transform.position.y > 0.49){
            movable = false;
            frag1Place = true;
            Debug.Log(movable);
        }
    }
}
