using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoSettings : MonoBehaviour
{
    public GameObject UI;
    AudioListener UIAudioListener;

    public GameObject SettingsArea;
    AudioListener SettingsAreaAudioListener;
    // Start is called before the first frame update
    void Start()
    {
        SettingsAreaAudioListener = SettingsArea.GetComponent<AudioListener>();
        UIAudioListener = UI.GetComponent<AudioListener>();
        UIAudioListener.enabled = true;
        SettingsAreaAudioListener.enabled = false;
        UI.SetActive(true);
        SettingsArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        UIAudioListener.enabled = false;
        UI.SetActive(false);

        SettingsAreaAudioListener.enabled = true;
        SettingsArea.SetActive(true);
    }
}
