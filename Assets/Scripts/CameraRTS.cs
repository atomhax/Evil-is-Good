using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRTS : MonoBehaviour {

    public float scrollZone = 30;
    public float scrollSpeed = 5;
    public float scrollWheelSens = 5;

    [Header("X Values")]
    public float xMax = 8;
    public float xMin = 0;

    [Header("Y Values")]
    public float yMax = 30;
    public float yMin = 3;

    [Header("Z Values")]
    public float zMax = 8;
    public float zMin = 0;

    private Vector3 desiredPosition;

    private void Start()
    {
        desiredPosition = transform.position;
    }

    void Update () {
        float x = 0, y = 0, z = 0;
        float speed = scrollSpeed * Time.deltaTime;

        if (Input.mousePosition.x < scrollZone || Input.GetKey("a"))
            x -= speed;
        else if (Input.mousePosition.x > Screen.width - scrollZone || Input.GetKey("d"))
            x += speed;

        if (Input.mousePosition.y < scrollZone || Input.GetKey("s"))
            z -= speed;
        else if (Input.mousePosition.y > Screen.height - scrollZone || Input.GetKey("w"))
            z += speed;

        y += Input.GetAxis("Mouse ScrollWheel") * scrollWheelSens;

        Vector3 move = new Vector3(x, y, z) + desiredPosition;
        move.x = Mathf.Clamp(move.x, xMin, xMax);
        move.y = Mathf.Clamp(move.y, yMin, xMax);
        move.z = Mathf.Clamp(move.z, zMin, zMax);
        desiredPosition = move;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.2f);
    }
}
