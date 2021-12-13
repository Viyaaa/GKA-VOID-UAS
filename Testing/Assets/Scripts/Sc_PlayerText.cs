using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PlayerText : MonoBehaviour
{
    public Text textDialogue;
    public Image paperImage;
    //public static bool isOpen = false;

    public Queue<string> textPlayer;

    private void Awake()
    {
        textDialogue.enabled = false;
    }

    private void Start()
    {
        textPlayer = new Queue<string>();
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
        ShowDialogue();
    }

    public void addText(string [] teks)
    {
        textPlayer.Clear();

        for(int i = 0; i < teks.Length; i++)
        {
            textPlayer.Enqueue(teks[i]);
        }

        ShowDialogue();
    }

    void ShowDialogue()
    {
        if(textPlayer.Count == 0)
        {
            Debug.Log("kelar");
            return;
        }

        string sentence = textPlayer.Dequeue();
        StartCoroutine(showTextLanjut(sentence, 2));

    }
}
