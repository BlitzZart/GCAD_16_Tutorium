using UnityEngine;
using System.Collections;

public class OrcCam : MonoBehaviour {

    OrcController orc;
    private float cameraSpeed = 10;

	// Use this for initialization
	void Start () {
        orc = FindObjectOfType<OrcController>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = orc.transform.position + Vector3.back * 10;


        transform.position = Vector3.Lerp(transform.position, orc.transform.position + Vector3.back * 10, cameraSpeed * Time.deltaTime);
    }
}
