using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1View : MonoBehaviour
{
    [SerializeField] private GameObject cont;
    public static bool Cfirsttime = true;
    [SerializeField] private GameObject Camera;
    Vector2 c1 = new Vector2 (-18, 11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Camera.transform.position = c1;
        penalizeCobra.playerLocation = "cacti";
        if (Cfirsttime){
            cont.GetComponent<CobraContinue>().clickCactus();
            Cfirsttime = false;
        }
    }
}
