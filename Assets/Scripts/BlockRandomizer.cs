using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRandomizer : MonoBehaviour {

    public Mesh Block1;
    public Mesh Block2;
    public Mesh Block3;

	// Use this for initialization
	void Start () {
        Invoke("Randomizer", 2f);
	}
	
	// Update is called once per frame
	void Randomizer () {
        int random = Random.Range(1, 11);
        if (random < 5)
        {
            gameObject.GetComponentInChildren<MeshFilter>().mesh = Block2;
        }
        else if (random > 5)
        {
            gameObject.GetComponentInChildren<MeshFilter>().mesh = Block1;
        }
        else if (random == 5)
        {
            gameObject.GetComponentInChildren<MeshFilter>().mesh = Block3;
        }
	}
}
