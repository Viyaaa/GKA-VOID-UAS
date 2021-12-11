using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_Projector : MonoBehaviour
{
    public bool isOn = false;

    public Material matKosong;
    public Material matIsi;

    [SerializeField] GameObject projector;
    [SerializeField] Light spotlight;

    private void Awake()
    {
        spotlight.intensity = 0;
        projector.GetComponent<MeshRenderer>().material = matKosong;
    }

    private void Update()
    {
        turnOnProjector();
    }

    public void turnOnProjector()
    {
        if (isOn)
        {
            spotlight.intensity = 12;
            projector.GetComponent<MeshRenderer>().material = matIsi;
        } else
        {
            spotlight.intensity = 0;
            projector.GetComponent<MeshRenderer>().material = matKosong;
        }
    }
}
