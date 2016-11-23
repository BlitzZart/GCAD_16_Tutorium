using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    private Rigidbody body;
    private float speed = 12000;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (Input.GetAxis("Horizontal") < 0) {
            body.AddTorque(0, 0, speed * Time.fixedDeltaTime);
        } else if (Input.GetAxis("Horizontal") > 0) {
            body.AddTorque(0, 0, -speed * Time.fixedDeltaTime);
        }
	}
}
