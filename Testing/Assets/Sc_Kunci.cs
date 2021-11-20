using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Kunci : MonoBehaviour
{
    Sc_PlayerText dialogPlayer;

    private void Start()
    {
        dialogPlayer = GameObject.FindObjectOfType<Sc_PlayerText>();
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(dialogPlayer.showTextLanjut("Kunci apa ini? Siapa yang menaruh kunci disini?"));
        Destroy(this.gameObject, 3);
    }
}
