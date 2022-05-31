using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeFox : MonoBehaviour
{
    [SerializeField] private CanvasGroup forest;
    [SerializeField] private GameObject Cam, cont, dialBox, paths;
    [SerializeField] private float forestSpeed;
    private bool fading = false;
    // Start is called before the first frame update
    void Start()
    {
        Cam.SetActive(false);
        dialBox.SetActive(false);
        fading = true;
        paths.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fading){
            if (forest.alpha < 1){
                forest.alpha += forestSpeed;
            }
            else{
                fading = false;
                Cam.SetActive(true);
                cont.GetComponent<FoxCont>().firstEnterFox();
            }
        }
    }
}
