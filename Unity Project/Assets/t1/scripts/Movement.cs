using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 0.5f;
    public float rotationSpeed = 150;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		}

	}
}
