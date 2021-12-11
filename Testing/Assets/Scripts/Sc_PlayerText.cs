using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PlayerText : MonoBehaviour
{
    public Text textDialogue;
    public Image paperImage;
    //public static bool isOpen = false;

    private void Awake()
    {
        textDialogue.enabled = false;
    }
    public void showPaper(bool isOpen)
    {
        if (isOpen == true)
        {
            paperImage.enabled = true;
        } else
        {
            paperImage.enabled = false;
        }
    }

    public IEnumerator showText()
    {
        yield return null;
    }

    public IEnumerator showTextLanjut(string text, int duration)
    {
        textDialogue.enabled = true;
        textDialogue.text = text;
        yield return new WaitForSeconds(duration);
        textDialogue.enabled = false;
    }
}
