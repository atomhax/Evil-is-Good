using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlock : MonoBehaviour {

    public GameObject apertureMask;
    public Vector3 apertureMaskSize;
    public LayerMask collideWith;

    private GameObject apertureMaskInst;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hitPoint;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitPoint, 40))
        {
            if (hitPoint.collider.gameObject.layer == collideWith)
            {
                apertureMaskInst = Instantiate(apertureMask, new Vector3(transform.position.x, 8f, transform.position.z), Quaternion.identity);
                apertureMaskInst.transform.localScale = apertureMaskSize;
            }
                

        }
        else
        {
            Debug.Log("No collider hit");
        }

    }
}
