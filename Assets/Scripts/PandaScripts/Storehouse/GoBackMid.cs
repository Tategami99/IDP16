using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackMid : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject LeftArrow;
    [SerializeField] private GameObject RightArrow;
    Vector2 mid = new Vector2 (0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        NumOHint.playerLocation = "";
        Camera.transform.position = mid;
        LeftArrow.SetActive(true);
        RightArrow.SetActive(true);
    }
}
