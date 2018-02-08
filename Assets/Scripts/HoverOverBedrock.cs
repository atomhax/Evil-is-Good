using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOverBedrock : MonoBehaviour {

    public GameObject selection;
    public AudioSource error;

    [Header("Positions")]
    public float axisY = 8.5f;       // Y Value

    [Header("Color")]
    public Color selcolor;

    private Transform t;             // This gameobject's transform
    private GameObject[] childObjects;

    // Use this for initialization
    void Awake () {
        t = gameObject.transform;
    }
	
	// Update is called once per frame
	void OnMouseOver () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Hit something?
        if (Physics.Raycast(ray, out hit, 300))
        {
            selection.transform.position = new Vector3(t.position.x, axisY, t.position.z);
            if (Input.GetMouseButtonDown(0))
            {
                error.Play();
            }
        }
        GameObject[] childObjects = selection.transform.GetComponentsInChildren<GameObject>();
        foreach (GameObject j in childObjects)
        {
            j.GetComponent<Renderer>().material.color = selcolor;
        }
    }
}
