using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortifyingWall : MonoBehaviour {

    [Header("Bools")]
    public bool currentlyFortifying;
    public bool Fortified;

    [Header("Fortified Brick GameObjects")]
    public GameObject FortifiedXPlus;
    public GameObject FortifiedXMinus;
    public GameObject FortifiedZPlus;
    public GameObject FortifiedZMinus;
    private GameObject InstantiatedWall;

    [Header("Misc.")]
    public LayerMask Fortifiedlayermask;

    // Use this for initialization
    void Start () {
        currentlyFortifying = false;
        BeenFortified();
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void BeenFortified()
    {
        if (Fortified == true)
        {
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), 5, Fortifiedlayermask))
            {
                InstantiatedWall = Instantiate(FortifiedXMinus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
            }
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), 5, Fortifiedlayermask))
            {
                InstantiatedWall = Instantiate(FortifiedZPlus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
            }
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), 5, Fortifiedlayermask))
            {
                InstantiatedWall = Instantiate(FortifiedZMinus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
            }
            if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), 5, Fortifiedlayermask))
            {
                InstantiatedWall = Instantiate(FortifiedXPlus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
            }
        }
    }
}
