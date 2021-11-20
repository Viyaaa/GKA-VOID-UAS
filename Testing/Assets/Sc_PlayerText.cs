using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PlayerText : MonoBehaviour
{
    public  Text textDialogue;

    private void Awake()
    {
        StartCoroutine(showText());
    }

    public IEnumerator showText()
    {
        textDialogue.enabled = false;
        yield return new WaitForSeconds(2);
        textDialogue.enabled = true;
        textDialogue.text = "Apakah yang terjadi disini?";
        yield return new WaitForSeconds(2);
        textDialogue.text = "Mengapa aku tidak bisa mengingat apapun. Bagaimana aku bisa disini?";
        yield return new WaitForSeconds(2);
        textDialogue.enabled = false;
    }

    public IEnumerator showTextLanjut(string text)
    {
        textDialogue.enabled = true;
        textDialogue.text = text;
        yield return new WaitForSeconds(2);
        textDialogue.enabled = false;
    }
}
