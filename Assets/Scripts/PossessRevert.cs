using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossessRevert : MonoBehaviour
{

    [Header("Cameras")]
    public GameObject RTS_Cam;
    public GameObject FirstPerson_Cam;
    public GameObject MiniMap;

    [Header("GameObjects")]
    public GameObject Creature;

    [Header("Canvas")]
    public GameObject Things;
    public GameObject Profile;

    private Transform CamTransform;

    public void Awake()
    {
        CamTransform = RTS_Cam.transform;
    }


    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FirstPerson_Cam.SetActive(false);
            RTS_Cam.SetActive(true);
            Things.SetActive(true);
            Profile.SetActive(false);
            MiniMap.transform.parent = RTS_Cam.transform;
            MiniMap.transform.position = new Vector3(CamTransform.position.x, MiniMap.transform.position.y, CamTransform.position.z);
            RTS_Cam.transform.rotation = new Quaternion(80f, 0f, 0f, 0f);
            gameObject.SetActive(false);
        }
            
    }
}

