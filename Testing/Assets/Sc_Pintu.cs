using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Pintu : MonoBehaviour
{
    public Animator anim;
    public int index = -1;
    public bool open = false;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void stateBukaPintu()
    {
        open = !open;
    }

    private void Update()
    {
        if(open)
        {
            anim.SetBool("bukaPintu", true);
        }
    }
}
