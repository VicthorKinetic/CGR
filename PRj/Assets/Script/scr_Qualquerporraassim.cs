using UnityEngine;
using System.Collections;

public class scr_Qualquerporraassim : MonoBehaviour {

	private RigidBody2D rb;
	public float velo;
	public bool Movimento;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (! Movimento)
		{
			rb.velocity = new Vector2 (0,rb.velocity.y);
		}

		Movimento = false;

		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) 
		{
			rb.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * velo, rb.velocity.y);
			Movimento = true;
		}

	
	}
}
