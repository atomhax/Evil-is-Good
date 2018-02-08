using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour
{
    public GameObject selection;
    public AudioSource dig;           // Sound
    private GameObject[] childObjects;

    [Header("Positions")]
    public float axisY = 8.5f;       // Y Value
    public float markY = 6.5f;        // For the marker

    [Header("Marker Detection")]
    public GameObject marker;         // Marker
    public LayerMask markerLayer;    // Marker layer
    public float markerRadius;   // Radius of sphere

    private Transform t;             // This gameobject's transform
    private GameObject markerObject;  // Marker instantiated clone

    void Awake()
    {
        t = gameObject.transform;
    }

    // Upon entering the dirtblock, gold, or Gems object which this script is attached to
    private void OnMouseOver()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Hit something?
        if (Physics.Raycast(ray, out hit, 300))
        {
            Debug.Log("You hit something!");
            selection.SetActive(true);

            // Set to current position with offset
            selection.transform.position = new Vector3(t.position.x, axisY, t.position.z);
            
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.CheckSphere(transform.position, markerRadius, markerLayer))
                {
                    Debug.Log("Clearing marker...");
                    dig.Play();
                    Destroy(markerObject);
                }
                else
                {
                    Debug.Log("Placing marker...");
                    dig.Play();
                    markerObject = Instantiate(marker, new Vector3(t.position.x, t.position.y + markY, t.position.z), t.rotation);
                    markerObject.SetActive(true);
                }
            }
            if (Input.GetMouseButtonDown(0))
            {

            }
        }
    }

    private void OnMouseExit()
    {
        selection.SetActive(false);
    }
}