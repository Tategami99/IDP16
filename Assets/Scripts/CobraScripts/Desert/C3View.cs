using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3View : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    [SerializeField] private GameObject Camera;
    Vector2 c3 = new Vector2 (-18, -11);
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
        Camera.transform.position = c3;
        penalizeCobra.playerLocation = "two";
        if (C1View.Cfirsttime){
            cont.GetComponent<CobraContinue>().clickCactus();
            C1View.Cfirsttime = false;
        }
    }
}
