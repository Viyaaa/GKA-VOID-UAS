using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadSceneAsync : MonoBehaviour
{
    bool isClicked = false;
    public void startTheGame()
    {
        if(!isClicked)
        {
            StartCoroutine(sceneLoadAsync());
            isClicked = true;
        }
    }

    public IEnumerator sceneLoadAsync()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("Abandoned_Asylum/Show");
        while(!async.isDone)
        {
            yield return null;
        }
    }
}
