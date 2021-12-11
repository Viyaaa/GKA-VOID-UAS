using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Loker : MonoBehaviour
{
    public Animator lokerAnim;
    public bool isOpen = false;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Key!");
            if (isOpen == false)
            {
                this.lokerAnim.SetBool("bukaLoker", true);
                isOpen = true;
            }
            else
            {
                this.lokerAnim.SetBool("bukaLoker", false);
                isOpen = false;
            }
        }
    }
}
