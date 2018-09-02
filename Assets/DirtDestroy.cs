using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class DirtDestroy : MonoBehaviour {

    public GameObject particles;
    public bool isBeingDigged;
    public float dirtAmount = 30;

	void Update () {
		if (dirtAmount == 0)
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.2f);
        }
        if (isBeingDigged == true) {
            for (int i = 30; i > dirtAmount; i--) {
                Instantiate(particles, transform.position, Quaternion.identity);
                dirtAmount--;
            }
        }
        
	}
}
