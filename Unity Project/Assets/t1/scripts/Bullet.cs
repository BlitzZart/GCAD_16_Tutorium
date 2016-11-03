using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 50;
	public float lifeTime = 5;

    Rigidbody body;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, lifeTime);
        body = GetComponent<Rigidbody>();

        body.AddForce(transform.forward * speed, ForceMode.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        print("velo " + body.velocity.magnitude);
	}
}