using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Sc_ClockControl : MonoBehaviour
{
    public AudioClip clip;
    float smooth = 5.0f;
    public GameObject biruCatClock;
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("Trigger");
            biruCatClock.transform.localPosition = new Vector3(-0.7f, 1.3f, 2.947489f);
            Quaternion target = Quaternion.Euler(-90f, -94.509f, 4.254f);
            biruCatClock.transform.localRotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = clip;
            audio.Play();
             Destroy(this);
            
        }
    }

    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
