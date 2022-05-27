using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoStorehouseDoor : MonoBehaviour
{
    [SerializeField] private TMP_Text textBox;
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject LeftArrow;
    [SerializeField] private GameObject RightArrow;
    Vector2 door = new Vector2 (0, 11);
    Vector2 DoorsHouseFront = new Vector2 (-18, 11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() {
        textBox.text = "";
        Debug.Log("clicked");
        if (GoDoorsHouse.EnteredFromDoorsHouse){
            Camera.transform.position = DoorsHouseFront;
        }
        else{
        Camera.transform.position = door;
        }
        LeftArrow.SetActive(false);
        RightArrow.SetActive(false);
        Keypad1.StorehousePasscode = "";
    }
}
