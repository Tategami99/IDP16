using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startEnterDialogue : MonoBehaviour
{
    [SerializeField] private CanvasGroup statue;
    [SerializeField] private float fadeSpeed;
    [SerializeField] private GameObject cont, Cam, dialBox, middle, map;
    private bool fading = false;
    // Start is called before the first frame update
    void Start()
    {
        dialBox.SetActive(false);
        Cam.SetActive(false);
        map.SetActive(false);
        fading = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (fading){
            if (statue.alpha < 1){
                statue.alpha += fadeSpeed;
            }
            else{
                fading = false;
                statue.alpha = 0;
                middle.SetActive(true);
                Cam.SetActive(true);
                cont.GetComponent<CobraContinue>().firstEnterCobra();
            }
        }
    }
}
