using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIalogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BackgroundTextWrite>().Run(textToType:"I have a new mission for you. Protect the Phoenix artifact located in the Museum of CAMS - the artifact rumored to give everlasting life to its holder. The Phoenix artifact has been broken into 3 pieces and each piece can be found in one of the enchanted exhibits. We don't know where exactly the pieces are located in the exhibit. However, we do know that the piece in the Panda exhibit must be collected first, then the piece in the Cobra exhibit, followed by the piece in the Fox exhibit. Retrieve the Phoenix artifact and restore the Museum of CAMS to its normal state.\n     Your mission begins now.", textLabel);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
