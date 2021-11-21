using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryAwal : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Abandoned_Asylum/Show", LoadSceneMode.Single);
    }
}
