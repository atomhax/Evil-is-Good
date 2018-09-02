using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkScript : MonoBehaviour {

	public bool isMarked;
	public GameObject marker;
	public float sphereRadius;
	private GameObject markerInst;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			if (isMarked == true) {
				markerInst = Instantiate(marker, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
			}
		}
		if (isMarked == false) {
			if (Physics.CheckSphere(new Vector3(transform.position.x, 0, transform.position.z), sphereRadius))
        	{
				Destroy(markerInst, 1f);
       		}
		}
	}
}

