using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_RuanganDialog : MonoBehaviour
{
    public int idx = 0;
    private string[] dialogPlayer = new string[10];
    private bool passed = false;

    private void OnTriggerEnter(Collider other)
    {
        Sc_PlayerText teks = FindObjectOfType<Sc_PlayerText>();

        switch (idx)
        {
            case 1: //105 kantin
                if(!passed)
                {
                    dialogPlayer[0] = "Sepertinya tempat ini sudah ditinggalkan, tidak ada tanda-tanda kehidupan disini.";
                    dialogPlayer[1] = "Ruang makan ini besar sekali, pasti X suka dengan tempat ini, dia kan suka makan.";
                    dialogPlayer[2] = "Siapa X? Kenapa tiba-tiba ku menyebutkan namanya?";
                    teks.addText(dialogPlayer);

                    passed = true;
                }

                break;
            case 2: //203
                if (!passed)
                {
                    dialogPlayer[0] = "Ada apa dengan ruangan ini? Menakutkan sekali.";
                    teks.addText(dialogPlayer);

                    passed = true;
                }

                break;

            case 3: //205 kelas
                if (!passed)
                {
                    dialogPlayer[0] = "Tempat ini luas sekali, seperti ruang kelas.";
                    teks.addText(dialogPlayer);

                    passed = true;
                }

                break;

            case 4: //kamar mandi
                if (!passed)
                {
                    dialogPlayer[0] = "Kenapa ada banyak darah disini?";
                    teks.addText(dialogPlayer);

                    passed = true;
                }

                break;

            case 5: //kamar mayat
                if (!passed)
                {
                    dialogPlayer[0] = "Apa ini.. Kenapa banyak sekali hasil otopsi";
                    teks.addText(dialogPlayer);

                    passed = true;
                }

                break;
        }
    }
}
