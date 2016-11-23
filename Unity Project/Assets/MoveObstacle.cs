using UnityEngine;
using System.Collections;

public class MoveObstacle : MonoBehaviour {
    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;
    private Vector2 originalPosition;

    private bool isPressed = false;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        originalPosition = transform.localPosition;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!isPressed) {
                body.transform.localPosition = originalPosition + Vector2.left;
            }
            else {
                body.transform.localPosition = originalPosition;
            }
            isPressed = !isPressed;
        }
    }
}