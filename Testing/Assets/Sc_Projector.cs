using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_Projector : MonoBehaviour
{
    public bool isOn = false;
    public bool isPlaying = false;

    public Material matKosong;
    public Material matIsi;

    [SerializeField] GameObject projector;
    [SerializeField] Light spotlight;

    [SerializeField] AudioSource projectorSound;
    [SerializeField] AudioClip projectorSoundClip;
    [SerializeField] AudioClip projectorSoundClipisPlay;

    private void Awake()
    {
        spotlight.intensity = 0;
        projector.GetComponent<MeshRenderer>().material = matKosong;
        projectorSound = GetComponent<AudioSource>();
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
            if(!isPlaying)
            {
                StartCoroutine(playProjectorSound());
                isPlaying = true;
            }
        } else
        {
            spotlight.intensity = 0;
            projector.GetComponent<MeshRenderer>().material = matKosong;
            
            
            if(isPlaying)
            {
                projectorSound.Stop();
                projectorSound.PlayOneShot(projectorSoundClip);
                isPlaying = false;
            }
        }
    }

    IEnumerator playProjectorSound()
    {
        projectorSound.PlayOneShot(projectorSoundClip);
        yield return new WaitForSeconds(0.1f);
        projectorSound.PlayOneShot(projectorSoundClipisPlay);
    }
}
