using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMain : MonoBehaviour
{
    public void startApp()
    {
        SceneManager.LoadScene("Arfoundation");
    }
    public void QuitApp()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    
    public void IntroMenu()
    {
        SceneManager.LoadScene("Intro");
    }
}
