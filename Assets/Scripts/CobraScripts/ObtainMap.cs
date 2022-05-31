using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtainMap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer background, slot1;
    [SerializeField] private Sprite noMap, map;
    [SerializeField] private GameObject cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        cont.GetComponent<CobraContinue>().mapObtained();
        background.sprite = noMap;
        slot1.sprite = map;
        AddItemToInventory.slot1full = true;
    }
}
