using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PlayerText : MonoBehaviour
{
    public Text textDialogue;
    public Image paperImage;
    public Image blackImage;
    //public static bool isOpen = false;
    private string mode;
    public GameObject lastObject;

    public Queue<string> textPlayer;

    private void Awake()
    {
        blackImage.enabled = false;
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

    public void addText(string [] teks, string mode)
    {
        textPlayer.Clear();

        for(int i = 0; i < teks.Length; i++)
        {
            textPlayer.Enqueue(teks[i]);
        }

        this.mode = mode;

        ShowDialogue();
    }

    void ShowDialogue()
    {
        if(textPlayer.Count == 0)
        {
            if(this.mode.Contains("normal"))
            {
                Debug.Log("kelar");
                return;
            } else if (this.mode.Contains("bad"))
            {
                Sc_Camera2 badEnd = FindObjectOfType<Sc_Camera2>();
                badEnd.badEndSorry();
                return;
            }
        }
        Debug.Log(textPlayer.Count);
        string sentence = textPlayer.Dequeue();
        StartCoroutine(showTextLanjut(sentence, 3));
    }

    public IEnumerator wink()
    {
        blackImage.enabled = true;
        yield return new WaitForSeconds(0.2f);
        blackImage.enabled = false;
        lastObject.SetActive(true);
    }
}
