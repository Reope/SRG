using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject M1;
    public GameObject M21;
    public GameObject M22;
    public GameObject M23;
    public GameObject M24;
    public GameObject M25;
    public GameObject M26;
    public GameObject M27;
    public GameObject M28;
    public GameObject M29;
    public GameObject M210;
    public GameObject BPack;
    public GameObject M31;
    public GameObject M32;
    public GameObject M33;
    public GameObject M34;
    public GameObject M35;
    public GameObject M36;
    public GameObject M37;
    public GameObject M38;
    public GameObject M39;
    public GameObject M310;



    public int M1List;
    public bool M1ok;
    public int M222;
    public bool iskey;

	// Use this for initialization
	void Start () {
        M222 = 1;
        M1List = 1;
        M1ok = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            iskey =! iskey;
        }
        if (iskey) {
            M1.SetActive(true);
            BPack.SetActive(true);
        }
        else
        {
            M1.SetActive(false);
            BPack.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.W) & (M1ok == false))
        {
            M222 = M222 - 1;
        }
        if (Input.GetKeyUp(KeyCode.S) & (M1ok == false))
        {
            M222 = M222 + 1;
        }


        if (Input.GetKeyUp(KeyCode.W) & (M1ok == true))
        {
            M1List = M1List - 1;
        }
        if (Input.GetKeyUp(KeyCode.S) & (M1ok == true))
        {
            M1List = M1List + 1;
        }

        if (Input.GetKeyUp(KeyCode.D) & (M1ok == false))
        {
            M1ok = true;
        }
        if (Input.GetKeyUp(KeyCode.A) & (M1ok == true))
        {
            M1ok = false;
        }


        if (M222 >= 11)
        {
            M222 = 1;
        }
        if (M222 <= 0)
        {
            M222 = 10;
        }

        if (M1List >= 11)
        {
            M1List = 1;
        }
        if (M1List <= 0)
        {
            M1List = 10;
        }


       

        if (M222 == 1 & iskey == true)
        {
            M21.SetActive(true);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
       }
        if (M222 == 2 & iskey == true)
                {
            M21.SetActive(false);
            M22.SetActive(true);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 3 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(true);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 4 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(true);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 5 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(true);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 6 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(true);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 7 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(true);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 8 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(true);
            M29.SetActive(false);
            M210.SetActive(false);
        }
        if (M222 == 9 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(true);
            M210.SetActive(false);
        }
        if (M222 == 10 & iskey == true)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(true);
        }
        if (M222 == 0 || iskey == false)
        {
            M21.SetActive(false);
            M22.SetActive(false);
            M23.SetActive(false);
            M24.SetActive(false);
            M25.SetActive(false);
            M26.SetActive(false);
            M27.SetActive(false);
            M28.SetActive(false);
            M29.SetActive(false);
            M210.SetActive(false);
        }

        }
    }

