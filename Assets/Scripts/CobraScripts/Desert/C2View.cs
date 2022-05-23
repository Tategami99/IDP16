using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2View : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject Camera;
    Vector2 c2 = new Vector2 (-36, 0);
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
        Camera.transform.position = c2;
        if (C1View.Cfirsttime){
            cont.GetComponent<CobraContinue>().clickCactus();
            C1View.Cfirsttime = false;
        }
    }
}
