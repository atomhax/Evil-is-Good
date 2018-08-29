using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortifyingGround : MonoBehaviour {

    [Header("None")]
    public GameObject Smoke;
    private GameObject FortifiedItem;
    public GameObject ApertureMask;
    private GameObject apertureMaskInst;
    public Material Normal;
    public Material Fortified;
    public bool currentlyFortifying;
    public bool fortified;

    [Header("Rooms")]
    public GameObject GoldRoom;
    public GameObject Lair;
    public GameObject Hatchery;
    public GameObject TrainingRoom;
    public GameObject Library;

    [Header("Red")]
    public GameObject FortifiedRed;
    public bool fortifiedRed;
    [Header("Blue")]
    public GameObject FortifiedBlue;
    public bool fortifiedBlue;
    [Header("Green")]
    public GameObject FortifiedGreen;
    public bool fortifiedGreen;
    [Header("Yellow")]
    public GameObject FortifiedYellow;
    public bool fortifiedYellow;
    [Header("White")]
    public GameObject FortifiedWhite;
    public bool fortifiedWhite;
    
    [Header("Misc.")]
    public bool neverDoneFirst;
    public bool neverDoneSecond;
    public bool neverDoneThird;

    // Use this for initialization
    void Start () {
        neverDoneFirst = true;
        neverDoneSecond = true;
		if (fortified == true)
        {
            gameObject.GetComponentInChildren<Renderer>().material = Fortified;
            gameObject.tag = "FortifiedGround";
        }
        if (fortified == false)
        {
            gameObject.GetComponentInChildren<Renderer>().material = Normal;
            gameObject.tag = "Ground";
            Destroy(FortifiedItem);
        }
        if (fortifiedRed == true)
        {
            FortifiedItem = Instantiate(FortifiedRed, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
            apertureMaskInst = Instantiate(ApertureMask, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), transform.rotation);
        }
        if (fortifiedBlue == true)
        {
            FortifiedItem = Instantiate(FortifiedBlue, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
        }
        if (fortifiedGreen == true)
        {
            FortifiedItem = Instantiate(FortifiedGreen, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
        }
        if (fortifiedYellow == true)
        {
            FortifiedItem = Instantiate(FortifiedYellow, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
        }
        if (fortifiedWhite == true)
        {
            FortifiedItem = Instantiate(FortifiedWhite, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (fortified == true && neverDoneFirst == true)
        {
            gameObject.GetComponentInChildren<Renderer>().material = Fortified;
            gameObject.tag = "FortifiedGround";
            neverDoneFirst = false;
        }
        if (fortified == false && neverDoneThird == true)
        {
            gameObject.GetComponentInChildren<Renderer>().material = Normal;
            Destroy(FortifiedItem);
            gameObject.tag = "Ground";
            neverDoneThird = false;
        }
        if (fortifiedRed == true && neverDoneSecond == true)
        {
            FortifiedItem = Instantiate(FortifiedRed, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
            apertureMaskInst = Instantiate(ApertureMask, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), transform.rotation);
            neverDoneSecond = false;
        }
        if (fortifiedBlue == true && neverDoneSecond == true)
        {
            FortifiedItem = Instantiate(FortifiedBlue, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
            neverDoneSecond = false;
        }
        if (fortifiedGreen == true && neverDoneSecond == true)
        {
            FortifiedItem = Instantiate(FortifiedGreen, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
            neverDoneSecond = false;
        }
        if (fortifiedYellow == true && neverDoneSecond == true)
        {
            FortifiedItem = Instantiate(FortifiedYellow, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
            neverDoneSecond = false;
        }
        if (fortifiedWhite == true && neverDoneSecond == true)
        {
            FortifiedItem = Instantiate(FortifiedWhite, new Vector3(transform.position.x, -0.225f, transform.position.z), transform.rotation);
            neverDoneSecond = false;
        }
    }
}
