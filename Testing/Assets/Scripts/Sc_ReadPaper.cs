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
    public Image paper8;
    public Image paper9;
    public Image paper10;
    public Image paper11;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    public Image paper12;
=======
>>>>>>> Stashed changes
=======
    public Image paper12;
>>>>>>> Stashed changes

    private string[] dialogPlayer = new string[4];
    private bool paper1read = false;
    private bool paper3read = false;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    private bool paper8read = false;
    
=======
    private bool paper7read = false;
    private bool paper8read = false;

>>>>>>> Stashed changes
=======
    private bool paper7read = false;
    private bool paper8read = false;
>>>>>>> Stashed changes

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
                case 8:
                    paper8.enabled = true;
                    break;
                case 9:
                    paper9.enabled = true;
                    break;
                case 10:
                    paper10.enabled = true;
                    break;
                case 11:
                    paper11.enabled = true;
                    break;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                case 12:
                    paper12.enabled = true;
                    break;

=======
>>>>>>> Stashed changes
                
=======
                case 12:
                    paper12.enabled = true;
                    break;
                

>>>>>>> Stashed changes
            }
        } else
        {
            switch (idx)
            {
                case 1:
                    paper1.enabled = false;
                    Sc_PlayerText teksPertama = FindObjectOfType<Sc_PlayerText>();

                    if(!paper1read)
                    {
                        dialogPlayer[0] = "Ada apa dengan isi dari diary ini? Kenapa dia begitu marah melihat anak-anak tertawa?";
                        dialogPlayer[1] = "Aku tidak mengerti apa yang dimaksud oleh secarik kertas ini.";
                        dialogPlayer[2] = "Kenapa aku merasakan sakit di dadaku ketika melihat isi dari kertas ini?";
                        dialogPlayer[3] = "Mungkin hanya firasatku saja, lebih baik cari tahu bagaimana aku bisa keluar dari tempat ini.";
                        teksPertama.addText(dialogPlayer, "normal");

                        paper1read = true;
                    }
                    break;
                case 2:
                    paper2.enabled = false;
                    break;
                case 3:
                    paper3.enabled = false;
                    Sc_PlayerText teksTiga = FindObjectOfType<Sc_PlayerText>();

                    if (!paper3read)
                    {
                        dialogPlayer[0] = "Siapa orang yang ada di foto ini? Mengapa ada surat yang berisikan minta tolong dan meminta ampun?";
                        dialogPlayer[1] = "Apa yang telah ia perbuat sampai menuliskan minta tolong menggunakan darah?";
                        teksTiga.addText(dialogPlayer, "normal");

                        paper3read = true;
                    }

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
                    Sc_PlayerText teksTujuh = FindObjectOfType<Sc_PlayerText>();

                    if (!paper7read)
                    {
                        dialogPlayer[0] = "Kenapa dia menulis dengan darah? Sebenarnya apa yang telah mereka alami hingga seperti ini?";
<<<<<<< Updated upstream
                        teksTujuh.addText(dialogPlayer);
=======
                        teksTujuh.addText(dialogPlayer, "normal");
>>>>>>> Stashed changes

                        paper7read = true;
                    }
                    break;
                case 8:
                    paper8.enabled = false;
                    Sc_PlayerText teksDelapan = FindObjectOfType<Sc_PlayerText>();

                    if (!paper8read)
                    {
                        dialogPlayer[0] = "Emily!? Sepertinya namanya tidak begitu asing diingatan ku.";
                        dialogPlayer[1] = "Em.. Emily.. aku ingat sekarang.. Emily anakku diperkosa dan dibunuh oleh anak-anak bajingan itu!";
<<<<<<< Updated upstream
                        dialogPlayer[2] = "Maafkan ayah nak! Ayah sudah membalaskan dendam mu kepada anak-anak yang telah merengut senyum mu.";
                        teksDelapan.addText(dialogPlayer);

                        paper8read = true;
                    }
                    break;
                case 9:
                    paper9.enabled = false;
                    break;
                case 10:
                    paper10.enabled = false;
                    break;
                case 11:
                    paper11.enabled = false;
                    break;
                case 8:
                    paper8.enabled = false;
                    Sc_PlayerText teksDelapan = FindObjectOfType<Sc_PlayerText>();

                    if (!paper8read)
                    {
                        dialogPlayer[0] = "Emily!? Sepertinya namanya tidak begitu asing diingatan ku.";
                        dialogPlayer[1] = "Em.. Emily.. aku ingat sekarang.. Emily anakku diperkaos dan dibunuh oleh anak-anak bajingan itu!";
                        dialogPlayer[2] = "Maafkan ayah nak! Ayah sudah membalaskan dendam mu kepada anak-anak yang telah merengut senyum mu.";
                        teksDelapan.addText(dialogPlayer);
=======
                        dialogPlayer[2] = "Maafkan ayah nak! Ayah sudah membalaskan dendam mu kepada anak-anak yang telah merengut senyummu.";

                        Sc_Camera2 isHappy = FindObjectOfType<Sc_Camera2>();
                        if (isHappy.points == 10)
                        {
                            teksDelapan.addText(dialogPlayer, "normal");
                            Debug.Log("Happy Ending");
                            StartCoroutine(teksDelapan.wink());
                        }
                        else
                        {
                            Debug.Log("Bad Ending");
                            teksDelapan.addText(dialogPlayer, "bad");
                        }
>>>>>>> Stashed changes

                        paper8read = true;
                    }
                    break;
                case 9:
                    paper9.enabled = false;
                    break;
                case 10:
                    paper10.enabled = false;
                    break;
                case 11:
                    paper11.enabled = false;
                    break;
                case 12:
                    paper12.enabled = false;
                    break;
                
            }
        }
    }
}
