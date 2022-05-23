using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cEnterKey : MonoBehaviour
{
    [SerializeField] private GameObject frag2;
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject Camera;
    Vector2 inside = new Vector2 (0, -11);
    [SerializeField] private SpriteRenderer insideBackground;
    [SerializeField] private Sprite insideWithDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (c9key.cobraStatueCode == "9"){
            Debug.Log("unlocked");
            insideBackground.sprite = insideWithDoor;
            Camera.transform.position = inside;
            frag2.SetActive(true);
        }
    }
}
