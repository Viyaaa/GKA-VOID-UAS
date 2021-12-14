using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_Laptop : MonoBehaviour
{
    [SerializeField] GameObject laptopOn;
    [SerializeField] GameObject teksInputPassword;
    [SerializeField] InputField teksLaptop;
    public string passwordPintu = "12345";
    string input = "";

    private string[] dialogPlayer = new string[10];
    private bool passed = false;

    public bool isOff = false;

    private void Awake()
    {
        teksInputPassword.SetActive(false);
    }

    private void Update()
    {
        if(isOff)
        {
            //matiin laptop
            laptopOn.SetActive(true);

            teksLaptop.text = "";

            teksInputPassword.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        } else
        {
            //nyalain laptop
            laptopOn.SetActive(true);

            teksInputPassword.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }
    }

    public void passwordLaptop()
    {
        Debug.Log(teksLaptop.text.ToString());
        input = teksLaptop.text.ToString();

        Playsound passLaptop = FindObjectOfType<Playsound>();
        passwordLaptop(input);
    }

    public void passwordLaptop(string passLaptop)
    {
        if (passLaptop.Length >= 8)
        {
            if (passLaptop == passwordPintu)
            {
                passLaptop = "";
                int indexKunciPintuPass = FindObjectOfType<Sc_Kunci>().index;
                //FindObjectOfType<Sc_PintuPassword>().isClose = true;
                Sc_InventoryKunci.kuncis[indexKunciPintuPass] = true;
                //Destroy(this.gameObject);
                Debug.Log("buka pintunya");
                isOff = true;
                teksInputPassword.SetActive(false);
                Time.timeScale = 1f;

                Sc_PlayerText teks = FindObjectOfType<Sc_PlayerText>();

                if (!passed)
                {
                    dialogPlayer[0] = "Paranoia? Sepertinya sebelum aku hilang ingatan aku pernah mengalami hal ini dan yang ku ingat hanyalah aku bersembunyi di kamar mandi karena terlalu takut.";
<<<<<<< Updated upstream
                    teks.addText(dialogPlayer);
=======
                    teks.addText(dialogPlayer, "normal");
>>>>>>> Stashed changes

                    passed = true;
                }
            }
            else
            {
                isOff = false;
            }
        }
        else
        {
            Debug.Log("salah ya password laptopnya.");
        }
    }
}
