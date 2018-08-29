using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClose : MonoBehaviour {

    public LayerMask layerMask;

    private void Awake()
    {
        
    }
    void Update () {
        Collider[] Objects = Physics.OverlapSphere(transform.position, 2f, layerMask);

        foreach (Collider rch in Objects) {
            if (rch.gameObject.layer == layerMask)
            {
                Destroy(rch.gameObject);
            }
        }
    }
}
