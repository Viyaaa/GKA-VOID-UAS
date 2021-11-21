using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Camera2 : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;

    public Transform playerBody;

    float xRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // get the mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minTurnAngle, maxTurnAngle);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        GetKey();
    }

    void GetKey()
    {
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        Debug.DrawRay(this.transform.position, this.transform.forward * 3,
        Color.red);
        RaycastHit hit;
        bool isRayHit = Physics.Raycast(ray, out hit, 3);
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isRayHit)
            {
                if (hit.collider.CompareTag("pintu"))
                {
                    Sc_Pintu pintu = hit.collider.GetComponent<Sc_Pintu>();

                    if (pintu == null) return;
                    if (Sc_InventoryKunci.kuncis[pintu.index] == true)
                    {
                        Debug.Log("Bener Ini Pintunya.");
                        pintu.stateBukaPintu();
                    }
                }
                else if (hit.collider.CompareTag("kunci"))
                {
                    Sc_InventoryKunci.kuncis[hit.collider.GetComponent<Sc_Kunci>().index] = true;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
