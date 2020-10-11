using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D myRigidbody;

	public bool grounded;
	public LayerMask whatIsGround;

	private Collider2D myCollider;

	private Animator myAnimator;

	//bool doublejump = false; 
	public int jumpTimes = 1;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();

		myCollider = GetComponent<Collider2D> ();

		myAnimator = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Ground") {
			grounded = true;
			jumpTimes = 2;
		}

	}
	void OnTriggerExit2D (Collider2D other){
		if (other.tag == "Ground") {
			grounded = false;
		}

	}
	// Update is called once per frame
	void Update () {

		//grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);

		if (jumpTimes > 0) {	
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				//if(grounded || !doublejump)

				jumpTimes -= 1;
				myAnimator.SetBool ("Ground", false);

				myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce);

				myRigidbody.AddForce (new Vector2 (0f, jumpForce));
			}
				
			//doublejump = true;


				

		}

		myAnimator.SetFloat ("Speed", myRigidbody.velocity.x);
		myAnimator.SetBool ("Grounded", grounded );

		
		//Application.LoadLevel (1);
	}
}
