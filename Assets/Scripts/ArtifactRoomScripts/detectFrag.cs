using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectFrag : MonoBehaviour
{
    public static int numPlaced;
    public static bool frag1Selected = false;
    public static bool frag1Place = false;
    [SerializeField] private SpriteRenderer self, f2, f3; 
    [SerializeField] private Sprite f1sprite;
    [SerializeField] private GameObject f1;
    [SerializeField] private GameObject finalBox, highlight;
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
        if (frag1Selected){
            frag1Place = true;
            self.sprite = f1sprite;
            numPlaced += 1;
            f1.SetActive(false);
        }
        if (numPlaced == 3){
            Debug.Log("complete");
            finalBox.SetActive(true);
            highlight.SetActive(true);
            self.GetComponent<PolygonCollider2D>().enabled = false;
            f2.GetComponent<PolygonCollider2D>().enabled = false;
            f3.GetComponent<PolygonCollider2D>().enabled = false;
        }
        frag1Selected = false;
        detectFrag2.frag2Selected = false;
        detectFrag3.frag3Selected = false;
    }
}
