using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_gotoMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        toMainMenu();
    }

    public void toMainMenu()
    {
        FindObjectOfType<BackgroundMusic>().changetoMainMenu();
        Application.LoadLevel("uts/Scenes/MainMenu");
        //SceneManager.LoadScene("uts/Scenes/MainMenu");
        //Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
