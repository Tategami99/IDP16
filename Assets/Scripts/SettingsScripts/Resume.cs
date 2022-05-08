using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject SettingsArea;
    AudioListener SettingsAreaAudioListener;

    public GameObject UI;
    AudioListener UIAudioListener;
    // Start is called before the first frame update
    void Start()
    {
        SettingsAreaAudioListener = SettingsArea.GetComponent<AudioListener>();
        UIAudioListener = UI.GetComponent<AudioListener>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        SettingsAreaAudioListener.enabled = false;
        SettingsArea.SetActive(false);

        UIAudioListener.enabled = true;
        UI.SetActive(true);
    }
}