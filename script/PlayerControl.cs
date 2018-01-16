using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;

	public Transform groundCheck;
	public float groundCheckRadius;
	//LayerMask mask = 1 << 2; 表示开启Layer2。
	public LayerMask whatIsGround;
	private bool onGround;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		rb.velocity = new Vector2 (1, rb.velocity.y);
		this.onGround = Physics2D.OverlapCircle (groundCheck.position,this.groundCheckRadius,this.whatIsGround);

		if (Input.GetMouseButtonDown (0) && this.onGround) {
			rb.velocity = new Vector2 (rb.velocity.x, 4);
		}
	
	}
}
