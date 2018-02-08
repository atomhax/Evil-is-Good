using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClaimed : MonoBehaviour {

    [Header("Colors")]
    public Color RedColor;
    public Color BlueColor;
    public Color GreenColor;
    public Color YellowColor;
    public Color WhiteColor;

    private void Start()
    {
        Invoke("Red", 0.05f);
    }

    void Red () {
        gameObject.GetComponent<Renderer>().material.color = RedColor;
        Invoke("Blue", 0.05f);
    }

    void Blue () {
        gameObject.GetComponent<Renderer>().material.color = BlueColor;
        Invoke("Green", 0.05f);
    }

    void Green ()
    {
        gameObject.GetComponent<Renderer>().material.color = GreenColor;
        Invoke("Yellow", 0.05f);
    }

    void Yellow ()
    {
        gameObject.GetComponent<Renderer>().material.color = YellowColor;
        Invoke("White", 0.05f);
    }

    void White ()
    {
        gameObject.GetComponent<Renderer>().material.color = WhiteColor;
        Invoke("Red", 0.05f);
    }
}
