using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;
    public AudioSource mainMenu;
    public AudioSource inGame;
    void Awake(){

        if (backgroundMusic == null){
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else {
            Destroy(gameObject);
        }
    }

    public void changetoInGame()
    {
        Debug.Log("Masuk");
        this.mainMenu.Stop();
        inGame.Play();
    }

    public void changetoMainMenu()
    {
        this.mainMenu.Play();
        inGame.Stop();
    }
}
