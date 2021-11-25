using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_HtpNext : MonoBehaviour
{
    bool hlmKedua = false;
    public Image htpImg1;
    public Image htpImg2;
    public Text btnText;

    private void Awake()
    {
        htpImg1.enabled = true;
        htpImg2.enabled = false;
        btnText.text = "Next";
    }

    public void pindahHalaman()
    {
        if(hlmKedua == false)
        {
            htpImg2.enabled = true;
            htpImg1.enabled = false;
            btnText.text = "Previous";
            hlmKedua = true;
        } else
        {
            htpImg1.enabled = true;
            htpImg2.enabled = false;
            btnText.text = "Next";
            hlmKedua = false;
        }
    }
}
