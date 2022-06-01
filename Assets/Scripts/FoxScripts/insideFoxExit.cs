using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideFoxExit : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    private Vector2 outside = new Vector2 (0, 11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = outside;
        penalizeFox.playerLocation = "sign";
    }
}
