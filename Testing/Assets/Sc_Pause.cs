using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_Pause : MonoBehaviour
{
    [SerializeField] Slider sensitivity;
    [SerializeField] GameObject pauseScreen;
    public bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!isPaused)
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                pauseScreen.SetActive(true);
                isPaused = true;
            } 
            else
            {
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                pauseScreen.SetActive(false);
                isPaused = false;
            }
        }
        /*
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(isPaused)
            {
                FindObjectOfType<BackgroundMusic>().changetoMainMenu();
                Application.LoadLevel("uts/Scenes/MainMenu");
            }
        }*/
    }

    public float adjustSensitivity()
    {
        float mSensitivity = FindObjectOfType<Sc_Camera2>().mouseSensitivity;
        mSensitivity = mSensitivity * sensitivity.value;

        return mSensitivity;
    }
}
