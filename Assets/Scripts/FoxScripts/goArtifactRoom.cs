using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goArtifactRoom : MonoBehaviour
{
    [SerializeField] private SpriteRenderer foxBackground;
    [SerializeField] private Sprite artifactDoor;
    [SerializeField] private GameObject door, highlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        highlight.SetActive(false);
        foxBackground.sprite = artifactDoor;
        door.SetActive(true);
    }
}
