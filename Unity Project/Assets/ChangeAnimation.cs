using UnityEngine;
using System.Collections;

public class ChangeAnimation : MonoBehaviour {
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.SetBool("Change", true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
