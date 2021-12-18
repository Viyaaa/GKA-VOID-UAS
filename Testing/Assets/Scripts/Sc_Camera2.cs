using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Sc_Camera2 : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;

    public Text jumlahToys;
    public int points;

    public GameObject badEndingDialogue;
    public GameObject happyEndingDialogue;
    private bool isHappyEnding = false;

    public AudioSource emilySound;
    public AudioClip emilySoundClip;

    public Transform playerBody;

    float xRot = 0f;

    bool isOpen = false;

    private void Awake()
    {
        badEndingDialogue.SetActive(false);
        happyEndingDialogue.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // get the mouse inputs
        float mouseX = Input.GetAxis("Mouse X") * FindObjectOfType<Sc_Pause>().adjustSensitivity() * Time.smoothDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * FindObjectOfType<Sc_Pause>().adjustSensitivity() * Time.smoothDeltaTime;

        //Debug.Log("Sensi: "+ FindObjectOfType<Sc_Pause>().adjustSensitivity());

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minTurnAngle, maxTurnAngle);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        GetRes();
    }

    void GetRes()
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
                        if (pintu.index == 7)
                        {
                            Debug.Log("Heppy end");
                            giveHappyEnding();
                            return;
                        }
                        else
                        {
                            Debug.Log("Bener Ini Pintunya.");
                            pintu.stateBukaPintu();
                        }
                    }
                }
                else if (hit.collider.CompareTag("kunci"))
                {
                    Debug.Log("Kunci");
                    Sc_InventoryKunci.kuncis[hit.collider.GetComponent<Sc_Kunci>().index] = true;
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider.CompareTag("paper"))
                {
                    Debug.Log("Paper");
                    Sc_ReadPaper showPaper = FindObjectOfType<Sc_ReadPaper>();
                    Sc_Paper paper = FindObjectOfType<Sc_Paper>();
                    if(isOpen == false)
                    {
                        Debug.Log(hit.collider.GetComponent<Sc_Paper>().index);
                        showPaper.showPaper(hit.collider.GetComponent<Sc_Paper>().index, true);
                        Time.timeScale = 0f;
                        isOpen = true;
                    } else
                    {
                        Debug.Log(hit.collider.GetComponent<Sc_Paper>().index);
                        showPaper.showPaper(hit.collider.GetComponent<Sc_Paper>().index,false);
                        Time.timeScale = 1f;
                        isOpen = false;
                    }
                }
                else if (hit.collider.CompareTag("laptop"))
                {
                    Sc_Laptop laptop = FindObjectOfType<Sc_Laptop>();
                    if (!laptop.isOff)
                    {
                        laptop.isOff = true;
                        Time.timeScale = 1f;
                        Cursor.visible = false;
                    } else
                    {
                        laptop.isOff = false;
                        Time.timeScale = 0f;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }
                }
                else if (hit.collider.CompareTag("projector"))
                {
                    Sc_Projector projector = FindObjectOfType<Sc_Projector>();
                    if(!projector.isOn)
                    {
                        projector.isOn = true;
                    } else
                    {
                        projector.isOn = false;
                    }
                }
                else if (hit.collider.CompareTag("Toys"))
                {
                    points =  int.Parse(jumlahToys.text)+1;
                    jumlahToys.text = points.ToString();
                    Destroy(hit.collider.gameObject);
                    
                }
            }
        }

        if(isRayHit)
        {
            if(hit.collider.tag == "emily")
            {
                emilySound.PlayOneShot(emilySoundClip);
                Destroy(hit.collider.gameObject);
            }
        }
    }

    void giveHappyEnding()
    {
        FindObjectOfType<Sc_PlayerMov>().enabled = false;
        mouseSensitivity = 0f;
        happyEndingDialogue.SetActive(true);
        happyEndingDialogue.GetComponent<PlayableDirector>().Play();
    }

    public void badEndSorry()
    {
        FindObjectOfType<Sc_PlayerMov>().enabled = false;
        mouseSensitivity = 0f;
        badEndingDialogue.SetActive(true);
        badEndingDialogue.GetComponent<PlayableDirector>().Play();
    }
}
