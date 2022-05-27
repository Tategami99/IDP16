using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectFrag2 : MonoBehaviour
{
    public static bool frag2Selected = false;
    public static bool frag2Place = false;
    [SerializeField] private SpriteRenderer self, fr2, f3; 
    [SerializeField] private Sprite f2sprite;
    [SerializeField] private GameObject f2;
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
        if (frag2Selected){
            frag2Place = true;
            detectFrag.numPlaced += 1;
            self.sprite = f2sprite;
            f2.SetActive(false);
        }
        if (detectFrag.numPlaced == 3){
            Debug.Log("complete");
            finalBox.SetActive(true);
            self.GetComponent<PolygonCollider2D>().enabled = false;
            fr2.GetComponent<PolygonCollider2D>().enabled = false;
            f3.GetComponent<PolygonCollider2D>().enabled = false;
        }
        detectFrag.frag1Selected = false;
        frag2Selected = false;
        detectFrag3.frag3Selected = false;
    }
}
