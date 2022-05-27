using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectFrag3 : MonoBehaviour
{
    public static bool frag3Selected = false;
    public static bool frag3Place = false;
    [SerializeField] private SpriteRenderer self, f2, fr3; 
    [SerializeField] private Sprite f3sprite;
    [SerializeField] private GameObject f3;
    [SerializeField] private GameObject finalBox;
    // Start is called before the first frame update
    void Start()
    {
        self.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (frag3Selected){
            frag3Place = true;
            detectFrag.numPlaced += 1;
            self.sprite = f3sprite;
            f3.SetActive(false);
        }
        if (detectFrag.numPlaced == 3){
            Debug.Log("complete");
            finalBox.SetActive(true);
            self.GetComponent<PolygonCollider2D>().enabled = false;
            f2.GetComponent<PolygonCollider2D>().enabled = false;
            fr3.GetComponent<PolygonCollider2D>().enabled = false;
        }
        detectFrag.frag1Selected = false;
        detectFrag2.frag2Selected = false;
        frag3Selected = true;
    }
}
