using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    private bool movable = true;
    public static bool frag1Place = false;
    private void OnMouseDrag() {
        if (transform.position.x < 1.48 && transform.position.x > 1.10 && transform.position.y < 0.61 && transform.position.y > 0.49){
            movable = false;
            frag1Place = true;
            Debug.Log(movable);
        }
        if (movable){
            transform.position = GetMousePos();
        }
    }
    Vector3 GetMousePos(){
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 10;
        return mousePos;
    }
    private void Update(){
        if (transform.position.x < 1.48 && transform.position.x > 1.10 && transform.position.y < 0.61 && transform.position.y > 0.49){
            movable = false;
            frag1Place = true;
        }
    }
}