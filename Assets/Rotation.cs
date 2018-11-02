using UnityEngine;

public class Rotation : MonoBehaviour {

    // configurable fields
    public float rotationSpeed;

	// Update is called once per frame
	void FixedUpdate ()
	{
		transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
	}
}
