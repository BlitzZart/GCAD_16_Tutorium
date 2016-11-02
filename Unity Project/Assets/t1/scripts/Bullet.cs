using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 50;
	public float lifeTime = 5;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}