using UnityEngine;
using System.Collections;

public class OrcController : MonoBehaviour {

    float speed = 1800;
    float jumpForce = 1500;
    OrcAnimation orcAnimation;
    Rigidbody2D body;

    void Start() {
        orcAnimation = GetComponent<OrcAnimation>();
        body = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetAxis("Horizontal") > 0) {
            orcAnimation.WalkRight();
            body.AddForce(Vector2.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0) {
            body.AddForce(Vector2.left * speed);
            orcAnimation.WalkLeft();
        }
        else if (Input.GetButton("Talk")) {
            orcAnimation.Talk();
        }
        else {
            orcAnimation.Idle();
        }

        if (Input.GetButtonDown("Jump")) {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}