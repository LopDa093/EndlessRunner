using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play() {
        Debug.Log("Pressed");
        SceneManager.LoadScene("DanyTest");
    }

    public void QuitGame() {
        Debug.Log("Pressed");
        Application.Quit();
    }
    public void killMySelf() {
        Debug.Log("Pressed");
        Application.Quit();
    }
}
