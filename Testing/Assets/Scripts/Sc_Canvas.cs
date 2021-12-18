using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Sc_Canvas : MonoBehaviour
{
    public PlayableDirector playableDirector;
    private bool diPercepat = false;

    private void Start()
    {
        playableDirector.initialTime = 0;
        playableDirector.Play();
    }

    public void fastForwardKalimat()
    {
        if(!diPercepat)
        {
            playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(5);
            playableDirector.Play();
            diPercepat = true;
        } else
        {
            playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(1);
            playableDirector.Play();
            diPercepat = false;
        }

        
    }
}
