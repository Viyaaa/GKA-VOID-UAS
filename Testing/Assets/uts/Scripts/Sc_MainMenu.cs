using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_MainMenu : MonoBehaviour
{
    public void toSceneTeori()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void toSceneCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void toSettingCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }

    public void toHowToPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void mainGame()
    {
        SceneManager.LoadScene("Scenes/StoryAwal");
    }

    public void quitGame()
    {
        Debug.Log("Terima Kasih");
        Application.Quit();
    }
}
