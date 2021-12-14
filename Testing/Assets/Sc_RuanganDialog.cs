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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            case 1: //105 kantin
=======
            case 1: //
>>>>>>> Stashed changes
                if(!passed)
                {
                    dialogPlayer[0] = "Sepertinya tempat ini sudah ditinggalkan, tidak ada tanda-tanda kehidupan disini.";
                    dialogPlayer[1] = "Ruang makan ini besar sekali, pasti X suka dengan tempat ini, dia kan suka makan.";
                    dialogPlayer[2] = "Siapa X? Kenapa tiba-tiba ku menyebutkan namanya?";
                    teks.addText(dialogPlayer);
=======
            case 1: //kantin
                dialogPlayer[0] = "Sepertinya tempat ini sudah ditinggalkan, tidak ada tanda-tanda kehidupan disini.";
                dialogPlayer[1] = "Ruang makan ini besar sekali, pasti Emily suka dengan tempat ini, dia kan suka makan.";
                dialogPlayer[2] = "Siapa Emily? Kenapa tiba-tiba ku menyebutkan namanya?";
                teks.addText(dialogPlayer, "normal");
>>>>>>> Stashed changes

                Destroy(this);

                break;
<<<<<<< Updated upstream
            case 2: //203
                if (!passed)
                {
                    dialogPlayer[0] = "Ada apa dengan ruangan ini? Menakutkan sekali.";
                    teks.addText(dialogPlayer);
=======
            case 2: //205
                dialogPlayer[0] = "Ada apa dengan ruangan ini? Menakutkan sekali.";
                teks.addText(dialogPlayer, "normal");
>>>>>>> Stashed changes

                Destroy(this);

                break;

<<<<<<< Updated upstream
            case 3: //205 kelas
                if (!passed)
                {
                    dialogPlayer[0] = "Tempat ini luas sekali, seperti ruang kelas.";
                    teks.addText(dialogPlayer);
=======
            case 3: //kelas
                dialogPlayer[0] = "Tempat ini luas sekali, seperti ruang kelas.";
                dialogPlayer[1] = "Sepertinya ada beberapa barang yang masih dapat dinyalakan dari ruangan ini.";
                teks.addText(dialogPlayer, "normal");
>>>>>>> Stashed changes

                Destroy(this);

                break;

            case 4: //kamar mandi
<<<<<<< Updated upstream
                if (!passed)
                {
                    dialogPlayer[0] = "Kenapa ada banyak darah disini?";
                    teks.addText(dialogPlayer);

                    passed = true;
                }
=======
                dialogPlayer[0] = "Kenapa ada banyak darah disini?";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);
>>>>>>> Stashed changes

                break;

            case 5: //kamar mayat
<<<<<<< Updated upstream
                if (!passed)
                {
                    dialogPlayer[0] = "Apa ini.. Kenapa banyak sekali hasil otopsi";
                    teks.addText(dialogPlayer);

                    passed = true;
                }

                break;
=======
                dialogPlayer[0] = "Apa ini.. Kenapa banyak sekali hasil otopsi";
                teks.addText(dialogPlayer, "normal");

                Destroy(this);

                break;
            
>>>>>>> Stashed changes
        }
    }
}
