using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PintuPassword : MonoBehaviour
{
    public int index = -1;
    public GameObject keypad;
    public bool isClose = false;
    private void Awake()
    {
        closeKeypad(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(keypad != null)
        {
            if (isClose == false)
            {
                closeKeypad(true);
                Debug.Log("Tampilin UI Keypad");
            }
            else
            {
                closeKeypad(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(keypad != null)
        {
            if (isClose == true)
            {
                closeKeypad(false);
            }
        }


        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if(keypad != null)
        {
            closeKeypad(false);
        }
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = true;
    }

    void closeKeypad(bool isClosed)
    {
        this.keypad.SetActive(isClosed);
    }
}
