using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class log : MonoBehaviour
{
    [SerializeField] private GameObject playerManager;
    // Start is called before the first frame update
    void Start()
    {
        playerManager.GetComponent<playerManager>().startLogin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
