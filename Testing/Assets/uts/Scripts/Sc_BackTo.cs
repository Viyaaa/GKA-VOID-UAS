using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_BackTo : MonoBehaviour
{
    public void backToMainMenu()
    {
        if(SceneManager.GetActiveScene().name == "Teori")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if(SceneManager.GetActiveScene().name == "Credits")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        if(SceneManager.GetActiveScene().name == "AudioSetting")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        }
        if (SceneManager.GetActiveScene().name == "HowToPlay")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        }
    }
}
