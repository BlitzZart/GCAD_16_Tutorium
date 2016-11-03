using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject bulletPrefab;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate (bulletPrefab, transform.position, transform.rotation);
            audioSource.time = 0.45f;
            audioSource.Play();
		}
	}
}