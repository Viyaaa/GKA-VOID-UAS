using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_RuanganDialog : MonoBehaviour
{
    public int idx = 0;
    private string[] dialogPlayer = new string[3];
    private bool passed = false;

    private void OnTriggerEnter(Collider other)
    {
        Sc_PlayerText teks = FindObjectOfType<Sc_PlayerText>();

        switch (idx)
        {
            case 1: //kantin
                dialogPlayer[0] = "Sepertinya tempat ini sudah ditinggalkan, tidak ada tanda-tanda kehidupan disini.";
                dialogPlayer[1] = "Ruang makan ini besar sekali, pasti Emily suka dengan tempat ini, dia kan suka makan.";
                dialogPlayer[2] = "Siapa Emily? Kenapa tiba-tiba ku menyebutkan namanya?";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);

                break;
            case 2: //205
                dialogPlayer[0] = "Ada apa dengan ruangan ini? Menakutkan sekali.";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);

                break;

            case 3: //kelas
                dialogPlayer[0] = "Tempat ini luas sekali, seperti ruang kelas.";
                dialogPlayer[1] = "Sepertinya ada beberapa barang yang masih dapat dinyalakan dari ruangan ini.";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);

                break;

            case 4: //kamar mandi
                dialogPlayer[0] = "Kenapa ada banyak darah disini?";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);

                break;

            case 5: //kamar mayat
                dialogPlayer[0] = "Apa ini.. Kenapa banyak sekali hasil otopsi";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);

                break;
            
        }
    }
}
