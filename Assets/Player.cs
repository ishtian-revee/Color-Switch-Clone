using UnityEngine;

public class Player : MonoBehaviour {

    // configurable fields
    public float jumpForce;
    public Rigidbody2D rigidBody;
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
	    {
            rigidBody.velocity = Vector2.up * jumpForce;
	    }
	}
}
