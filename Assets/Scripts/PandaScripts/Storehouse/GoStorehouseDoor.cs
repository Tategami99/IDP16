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
    [SerializeField] private GameObject storeHandle;
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
        NumOHint.playerLocation = "storehouse";
        Debug.Log("clicked");
        if (GoDoorsHouse.EnteredFromDoorsHouse){
            Camera.transform.position = DoorsHouseFront;
        }
        else{
        Camera.transform.position = door;
        }
        LeftArrow.SetActive(false);
        RightArrow.SetActive(false);
        storeHandle.SetActive(true);
        Keypad1.StorehousePasscode = "";
        Keypad0.num = 0;
    }
}
