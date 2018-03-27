using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHover : MonoBehaviour {

    [Header("Values")]
    public float wallValue;
    public float floorValue;

    public LayerMask LayerGround;
    public LayerMask LayerWall;

    void Awake () {
    }
	
	void OnMouseOver () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



        if (Physics.Raycast(ray, out hit, 300))
        {
            if (hit.transform.gameObject.layer == LayerGround)
            {
                Debug.Log("FLOOR");
                gameObject.GetComponent<FollowCursor>().value = floorValue;
            }
            if (hit.transform.gameObject.layer == LayerWall)
            {
                Debug.Log("WALL");
                gameObject.GetComponent<FollowCursor>().value = wallValue;
            }
        }
    }
}
