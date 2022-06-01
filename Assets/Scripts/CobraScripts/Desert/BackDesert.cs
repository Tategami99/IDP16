using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDesert : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    Vector2 desert = new Vector2 (-18, 0);
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
        Camera.transform.position = desert;
        penalizeCobra.playerLocation = "";
    }
}
