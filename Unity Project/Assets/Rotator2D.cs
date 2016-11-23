using UnityEngine;
using System.Collections;

public class Rotator2D : MonoBehaviour {
    private Rigidbody2D body;
    private float speed = 12000;

    // Use this for initialization
    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetAxis("Horizontal") < 0) {
            body.AddTorque(speed * Time.fixedDeltaTime);
        }
        else if (Input.GetAxis("Horizontal") > 0) {
            body.AddTorque(-speed * Time.fixedDeltaTime);
        }
    }
}
