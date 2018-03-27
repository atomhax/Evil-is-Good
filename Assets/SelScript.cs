using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelScript : MonoBehaviour {

    public float axisY = 1.25f;
	
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 300) && hit.collider.tag == "Selectable")
        {
            gameObject.transform.position = new Vector3(hit.collider.transform.position.x, axisY, hit.collider.transform.position.z);
        }
    }
}
