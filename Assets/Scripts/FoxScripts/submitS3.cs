using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submitS3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (statuePasswords.s3pass == "cactus" || statuePasswords.s3pass == "Cactus" || statuePasswords.s3pass == "CACTUS"){
            Debug.Log("correct");
            statuePasswords.numCorrect += 1;
        }
    }
}
