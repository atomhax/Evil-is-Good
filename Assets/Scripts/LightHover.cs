using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHover : MonoBehaviour {

    public float zAxis;
    Vector3 mousePosition;

	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 30))
        {
            if (hit.transform.gameObject.tag == "Selectable")
            {
                Debug.Log("FLOOR");
                zAxis = 0.6f;
            }
            if (hit.transform.gameObject.tag == "Ground")
            {
                Debug.Log("WALL");
                zAxis = 1.1f;
            }
            gameObject.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zAxis);
        }
    }
}
