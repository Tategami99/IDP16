using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Username : MonoBehaviour
{
    public static string input;

    public void ReadStringInput(string name)
    {
        input = name;
        Debug.Log(input);
        SceneManager.LoadScene("PandaExhibit");
    }
}
