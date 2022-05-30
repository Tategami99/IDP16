using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToStatue : MonoBehaviour
{
    public static int playerLocation = 0;
    [SerializeField] private GameObject Camera, highlight, highlight2;
    Vector2 Statue = new Vector2 (0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (playerLocation != 0){
            highlight.SetActive(false);
            highlight2.SetActive(false);
            Camera.transform.position = Statue;
            playerLocation = 0;
        }
    }
}
