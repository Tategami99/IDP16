using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickFrag2 : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private SpriteRenderer render;
    [SerializeField] private Sprite withDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        door.SetActive(true);
        render.sprite = withDoor;
    }
}
