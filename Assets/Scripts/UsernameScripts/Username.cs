using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Username : MonoBehaviour
{
    public static string username;

    public void ReadStringInput(string name)
    {
        username = name;
        Debug.Log(username);
        SceneManager.LoadScene("Background");
    }
}
