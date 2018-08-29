using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dig : MonoBehaviour
{

    public GameObject fortifiedObject;
    public GameObject Imp;
    public float digTime;
    public float fortifiedTime;
    public bool fortified;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (fortified == false)
        {
            digTime = 10;
        }
        else
        {
            digTime = 3;
        }

        if (digTime < 0)
        {
            Destroy(gameObject);
            Destroy(fortifiedObject);
        }
        else
        {
            if (Imp.GetComponent<ImpDig>().Diggingwhat == gameObject)
            {
                digTime = digTime - 0.1f;
            }
        }
    }
}