using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelScript : MonoBehaviour {

    public float axisY = 1.1f;
    public LayerMask layer;
    public Material errorMat;
    public Material succesMat;

    public AudioSource markSound;
	
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 300f, layer))
        {
            if (hit.collider.gameObject.tag == "Diggable") {
                gameObject.SetActive(true);
                gameObject.GetComponentInChildren<MeshRenderer>().material = succesMat;
                gameObject.transform.position = new Vector3(hit.collider.gameObject.transform.position.x, axisY, hit.collider.gameObject.transform.position.z);
            }
            if (hit.collider.gameObject.tag == "Disabled") {
                gameObject.SetActive(true);
                gameObject.GetComponentInChildren<MeshRenderer>().material = errorMat;
                gameObject.transform.position = new Vector3(hit.collider.gameObject.transform.position.x, axisY, hit.collider.gameObject.transform.position.z);
                Debug.Log("You are on bedrock");
            }
            if (hit.collider.gameObject.layer == 12) {
                gameObject.SetActive(false);
            }
            if (hit.collider.gameObject.tag == "Mark") {
                gameObject.GetComponentInChildren<MeshRenderer>().material = succesMat;
                gameObject.transform.position = new Vector3(hit.collider.gameObject.transform.position.x, axisY, hit.collider.gameObject.transform.position.z);
            }
            if (Input.GetMouseButtonDown(0)) {
                    if (hit.collider.gameObject.GetComponent<MarkScript>().isMarked == false) {
                        hit.collider.gameObject.GetComponent<MarkScript>().isMarked = true;
                        Debug.Log("Marking");
                        markSound.Play();
                    }
                    if (hit.collider.gameObject.GetComponent<MarkScript>().isMarked == true) {
                        hit.collider.gameObject.GetComponent<MarkScript>().isMarked = false;
                        Debug.Log("Un-Marking");
                        markSound.Play();
                    }
                }
            
        }
    }
}
