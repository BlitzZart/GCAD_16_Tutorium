using UnityEngine;
using System.Collections;

public class OrcAnimation : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
	}

    public void Idle() {
        animator.SetBool("Walk", false);
        animator.SetBool("Talk", false);
    }

    public void Talk() {
        Idle();
        animator.SetBool("Talk", true);
    }

    public void WalkRight() {
        Idle();
        transform.localScale = new Vector3(1, 1, 1);
        animator.SetBool("Walk", true);
    }

    public void WalkLeft() {
        Idle();
        transform.localScale = new Vector3(-1, 1, 1);
        animator.SetBool("Walk", true);
    }

}