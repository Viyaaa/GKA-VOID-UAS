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
    }
}
