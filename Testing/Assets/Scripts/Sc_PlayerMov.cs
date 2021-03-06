using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_PlayerMov : MonoBehaviour
{
    public CharacterController controller;
    public AudioSource footstepPlayer;
    public AudioClip footstepSound;

    public float speed = 12f;

    public float gravity = -9.81f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    void MovementPlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(x > 0 || z > 0)
        {
            if(!footstepPlayer.isPlaying)
            {
                footstepPlayer.Play();
            }
        }
    }
}
