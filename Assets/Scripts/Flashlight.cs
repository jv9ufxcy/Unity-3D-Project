using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

    public Light flashlight;
    private bool isActive;
	// Use this for initialization
	void Start () {
        isActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Flashlight"))
        {
            if(isActive== false)
            {
                flashlight.enabled = true;
                isActive = true;
            }
            else if(isActive== true)
            {
                flashlight.enabled = false;
                isActive = false;
            }
        }
	}
}
