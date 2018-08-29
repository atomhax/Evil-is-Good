using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtDestroy : MonoBehaviour {

    public GameObject particles;
    public float dirtAmount;

	void Update () {
		if (dirtAmount == 0)
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.2f);
        }
	}
}
