using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_ReadPaper : MonoBehaviour
{
    public Image paper1;
    public Image paper2;
    public Image paper3;
    public Image paper4;
    public Image paper5;
    public Image paper6;
    public Image paper7;

    public void showPaper(int idx, bool isShow)
    {
        if(isShow == true)
        {
            switch(idx)
            {
                case 1:
                    paper1.enabled = true;
                    break;
                case 2:
                    paper2.enabled = true;
                    break;
                case 3:
                    paper3.enabled = true;
                    break;
                case 4:
                    paper4.enabled = true;
                    break;
                case 5:
                    paper5.enabled = true;
                    break;
                case 6:
                    paper6.enabled = true;
                    break;
                case 7:
                    paper7.enabled = true;
                    break;
            }
        } else
        {
            switch (idx)
            {
                case 1:
                    paper1.enabled = false;

                    Sc_PlayerText teks = FindObjectOfType<Sc_PlayerText>();

                    StartCoroutine(teks.showTextLanjut("Ada apa dengan isi dari diary ini? Kenapa dia begitu marah melihat anak-anak tertawa?", 3));

                    StartCoroutine(teks.showTextLanjut("Aku tidak mengerti apa yang dimaksud oleh secarik kertas ini.", 3));

                    break;
                case 2:
                    paper2.enabled = false;
                    break;
                case 3:
                    paper3.enabled = false;
                    break;
                case 4:
                    paper4.enabled = false;
                    break;
                case 5:
                    paper5.enabled = false;
                    break;
                case 6:
                    paper6.enabled = false;
                    break;
                case 7:
                    paper7.enabled = false;
                    break;
            }
        }
    }
}
