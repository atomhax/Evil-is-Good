using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSeam : MonoBehaviour {

    public int gold = 1024;

    public void Update()
    {
        if (gold == 0 || gold < 0)
        {
            Destroy(gameObject);
        }
    }
}
