using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Playsound : MonoBehaviour 
{
	[SerializeField] Text teksInputPassword;
	public string passwordPintu = "12345";
	string input = "";

	/*
    public void button0() { input = input + "0"; clicky(); }
	public void button1() { input = input + "1"; clicky(); }
	public void button2() { input = input + "2"; clicky(); }
	public void button3() { input = input + "3"; clicky(); }
	public void button4() { input = input + "4"; clicky(); }
	public void button5() { input = input + "5"; clicky(); }
	public void button6() { input = input + "6"; clicky(); }
	public void button7() { input = input + "7"; clicky(); }
	public void button8() { input = input + "8"; clicky(); }
	public void button9() { input = input + "9"; clicky(); }
	*/

    public void clicky()
    {
		GetComponent<AudioSource>().Play();
		GetComponent<AudioSource>().volume = 0.01f;
	}

    private void Update()
    {
		keypadNum();

		teksInputPassword.text = input;

		if(input.Length == 4)
        {
			if(input == passwordPintu)
            {
				input = "";
				int indexKunciPintuPass = FindObjectOfType<Sc_Kunci>().index;
				//FindObjectOfType<Sc_PintuPassword>().isClose = true;
				Sc_InventoryKunci.kuncis[indexKunciPintuPass] = true;
				Destroy(this.gameObject);
				Debug.Log("buka pintunya");	
            } else
            {
				input = ""; //kosongin lagi krn salah
				Debug.Log("salah ya passwordnya");
			}
        }
	}

	void keypadNum()
    {
		if (Input.GetKeyDown(KeyCode.Alpha0))
		{
			Debug.Log("Angka 0");
			input = input + "0";
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			input = input + "1";
			Debug.Log("Angka 1");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			input = input + "2";
			Debug.Log("Angka 2");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			input = input + "3";
			Debug.Log("Angka 3");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			input = input + "4";
			Debug.Log("Angka 4");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha5))
		{
			input = input + "5";
			Debug.Log("Angka 5");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha6))
		{
			input = input + "6";
			Debug.Log("Angka 6");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha7))
		{
			input = input + "7";
			Debug.Log("Angka 7");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha8))
		{
			input = input + "8";
			Debug.Log("Angka 8");
			Debug.Log("Input: " + input);
			clicky();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha9))
		{
			input = input + "9";
			Debug.Log("Angka 9");
			Debug.Log("Input: " + input);
			clicky();
		}
	}

	
	
	
}
