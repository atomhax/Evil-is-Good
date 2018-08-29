using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHover : MonoBehaviour {

    public float zAxis = 2f;
    Vector3 mousePosition;

    public LayerMask LayerGround;
    public LayerMask LayerWall;
    public LayerMask totalLayer;

	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 30, totalLayer))
        {
            if (hit.transform.gameObject.layer == LayerGround)
            {
                Debug.Log("FLOOR");
                zAxis = 0.6f;
            }
            if (hit.transform.gameObject.layer == LayerWall)
            {
                Debug.Log("WALL");
                zAxis = 1.1f;
            }
        }
    }
}
