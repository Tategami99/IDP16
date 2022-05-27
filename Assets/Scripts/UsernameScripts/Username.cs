using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Username : MonoBehaviour
{
    public static bool LoggedIn = false;
    public static string username = "Test";

    public void ReadStringInput(string name)
    {
        username = name;
        Debug.Log(username);
        SceneManager.LoadScene("Background");
    }
}
