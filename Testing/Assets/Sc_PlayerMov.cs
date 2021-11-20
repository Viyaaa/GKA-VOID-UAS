using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_PlayerMov : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public float gravity = -9.81f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        Ray ray = new Ray(this.transform.position, this.transform.forward);
        Debug.DrawRay(this.transform.position, this.transform.forward * 10,
        Color.red);
        RaycastHit hit;
        bool isRayHit = Physics.Raycast(ray, out hit, 10);
        if (isRayHit)
        {

            if (hit.collider.name == ("Door"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
