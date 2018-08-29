using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour {

    public AudioSource heartBeat;

    public void OnEvent () {
        heartBeat.Play();
	}
}
