using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortifyingWall : MonoBehaviour {

    [Header("Bools")]
    public bool currentlyFortifying;
    public bool Fortified;
    private bool neverDone;
    private bool neverDoneFront;
    private bool neverDoneBack;
    private bool neverDoneLeft;
    private bool neverDoneRight;
    private bool neverDoneFirst;

    [Header("Fortified Brick GameObjects")]
    public GameObject FortifiedXPlus;
    public GameObject FortifiedXMinus;
    public GameObject FortifiedZPlus;
    public GameObject FortifiedZMinus;
    private GameObject InstantiatedWallFront;
    private GameObject InstantiatedWallBack;
    private GameObject InstantiatedWallLeft;
    private GameObject InstantiatedWallRight;

    [Header("Team Embels")]
    public GameObject White;
    public GameObject Red;
    public GameObject Blue;
    public GameObject Green;
    public GameObject Yellow;
    public bool isWhite;
    public bool isRed;
    public bool isBlue;
    public bool isGreen;
    public bool isYellow;
    private GameObject Embel;

    [Header("Materials")]
    public Material normal;
    public Material fortified;

    [Header("Misc.")]
    public LayerMask Fortifiedlayermask;

    // Use this for initialization
    void Start () {
        neverDoneFront = true;
        neverDoneBack = true;
        neverDoneLeft = true;
        neverDoneRight = true;
        neverDone = true;
        neverDoneFirst = true;
        currentlyFortifying = false;
	}

    // Update is called once per frame
    void Update () {
        BeenFortified();
	}

    public void BeenFortified()
    {
        if (Fortified == true)
        {
            if (neverDone == true)
            {
                if (isWhite == true)
                {
                    Embel = Instantiate(White, new Vector3(transform.position.x, 0.8f, transform.position.z), Quaternion.identity);
                }
                if (isRed == true)
                {
                    Embel = Instantiate(Red, new Vector3(transform.position.x, 0.8f, transform.position.z), Quaternion.identity);
                }
                if (isBlue == true)
                {
                    Embel = Instantiate(Blue, new Vector3(transform.position.x, 0.8f, transform.position.z), Quaternion.identity);
                }
                if (isGreen == true)
                {
                    Embel = Instantiate(Green, new Vector3(transform.position.x, 0.8f, transform.position.z), Quaternion.identity);
                }
                if (isYellow == true)
                {
                    Embel = Instantiate(Yellow, new Vector3(transform.position.x, 0.8f, transform.position.z), Quaternion.identity);
                }
                gameObject.GetComponentInChildren<MeshRenderer>().material = fortified;
                neverDone = false;
            }
            if (!Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.TransformDirection(Vector3.left), 0.5f, Fortifiedlayermask) && neverDoneLeft == true)
            {
                InstantiatedWallLeft = Instantiate(FortifiedXMinus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                neverDoneLeft = false;
            }
            if (!Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.TransformDirection(Vector3.forward), 0.5f, Fortifiedlayermask) && neverDoneFront == true)
            {
                InstantiatedWallFront = Instantiate(FortifiedZPlus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                neverDoneFront = false;
            }
            if (!Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.TransformDirection(Vector3.back), 0.5f, Fortifiedlayermask) && neverDoneBack == true)
            {
                InstantiatedWallBack = Instantiate(FortifiedZMinus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                neverDoneBack = false;
            }
            if (!Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.TransformDirection(Vector3.right), 0.5f, Fortifiedlayermask) && neverDoneRight == true)
            {
                InstantiatedWallRight = Instantiate(FortifiedXPlus, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
                neverDoneRight = false;
            }
            neverDoneFirst = true;
        }
        if (Fortified == false && neverDoneFirst == true)
        {
            Destroy(InstantiatedWallBack);
            Destroy(InstantiatedWallFront);
            Destroy(InstantiatedWallLeft);
            Destroy(InstantiatedWallRight);
            Destroy(Embel);
            neverDoneLeft = true;
            neverDoneFront = true;
            neverDoneBack = true;
            neverDoneRight = true;
            gameObject.GetComponentInChildren<MeshRenderer>().material = normal;
            neverDone = false;
            neverDoneFirst = false;
        }
    }
}
