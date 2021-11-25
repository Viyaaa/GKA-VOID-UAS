using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_Teori : MonoBehaviour
{
    [SerializeField]
    GameObject soalSatu;
    GameObject soalABC;
    GameObject btnPindahSoal;

    bool keSoalDua = false;

    private void Start()
    {
        soalSatu = GameObject.Find("Soal 1");
        soalABC = GameObject.Find("Soal abc");
        btnPindahSoal = GameObject.Find("BtnPindahSoal");

        soalABC.SetActive(false);
        btnPindahSoal.GetComponentInChildren<Text>().text = "Soal 2";
    }

    public void toJawabanDua()
    {
        if(keSoalDua == false)
        {
            soalABC.SetActive(true);
            soalSatu.SetActive(false);
            keSoalDua = true;
            btnPindahSoal.GetComponentInChildren<Text>().text = "Soal 1";            
        }

        else
        {
            soalABC.SetActive(false);
            soalSatu.SetActive(true);
            keSoalDua = false;
            btnPindahSoal.GetComponentInChildren<Text>().text = "Soal 2";
        }
        
    }
}
