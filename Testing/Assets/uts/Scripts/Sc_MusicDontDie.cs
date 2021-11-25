using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_MusicDontDie : MonoBehaviour
{

    private static GameObject instance;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
