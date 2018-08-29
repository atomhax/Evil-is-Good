using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCubeButton : MonoBehaviour {

	Vector3 mousePos;

	void Start () {
		gameObject.GetComponent<Animator>().StopPlayback();
	}

	void Update () {
		RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            gameObject.GetComponent<Animator>().Play("BoxHover");
            Debug.Log("Did Hit");
        }
        else
        {
            gameObject.GetComponent<Animator>().StopPlayback();
            Debug.Log("Did not Hit");
        }
	}
}
