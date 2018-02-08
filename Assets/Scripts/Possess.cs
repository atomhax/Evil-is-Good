using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Possess : MonoBehaviour {

    [Header("Cameras")]
    public GameObject RTS_Cam;
    public GameObject FirstPerson_Cam;
    public GameObject MiniMap;

    [Header("GameObjects")]
    public GameObject Creature;
    public GameObject Revert;

    [Header("Canvas")]
    public GameObject Things;
    public GameObject Profile;

    [Header("Sounds")]
    public AudioSource Possess_Sound;

    // Update is called once per frame
    public void OnMouseClick () {
        Possess_Sound.Play();
        FirstPerson_Cam.SetActive(true);
        RTS_Cam.SetActive(false);
        Things.SetActive(false);
        Profile.SetActive(true);
        Revert.SetActive(true);
        MiniMap.transform.parent = Creature.transform;
        MiniMap.transform.position = new Vector3(Creature.transform.position.x, MiniMap.transform.position.y, Creature.transform.position.z);
    }
}
