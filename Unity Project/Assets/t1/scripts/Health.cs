using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float maxHealth = 10;
    public float currentHealth;

    public AudioClip explosionSound;

    public GameObject exposionPrefab;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy() {
        AudioSource.PlayClipAtPoint(explosionSound, new Vector3(0,23,-21));
    }

    public void Hit(float damage) {
        currentHealth = currentHealth - damage;

        if (currentHealth <= 0) {
            Instantiate(exposionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
