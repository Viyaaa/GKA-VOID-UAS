using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class loadSceneAsync : MonoBehaviour
{
    public Text textToStart;
    public PlayableDirector pDir;
    public bool isPressed = false;

    private void Start()
    {
        textToStart.enabled = false;
        StartCoroutine(sceneLoadAsync());
    }

    public void startPlay()
    {
        isPressed = true;
    }

    public IEnumerator sceneLoadAsync()
    {
        float foo = 0f;
        AsyncOperation async = SceneManager.LoadSceneAsync("Abandoned_Asylum/Show");
        async.allowSceneActivation = false;
        while(!async.isDone)
        {
            if (async.progress >= 0.9f)
            {
                if(isPressed)
                {
                    async.allowSceneActivation = true;
                }
            }
            
            yield return null;
        }
    }
}
