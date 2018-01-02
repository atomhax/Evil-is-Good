using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollInAndOut : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            GetComponent<Camera>().fieldOfView--;
        }
        if (Input.GetAxis ("Mouse ScrollWheel") < 0f)
        {
            GetComponent<Camera>().fieldOfView++;
        }
        if (GetComponent<Camera>().fieldOfView >= 100)
        {
            GetComponent<Camera>().fieldOfView = 100;
        }
        if (GetComponent<Camera>().fieldOfView <= 30)
        {
            GetComponent<Camera>().fieldOfView = 30;
        }

    }
}
