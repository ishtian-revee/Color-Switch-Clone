using UnityEngine;

public class Circle : MonoBehaviour {

    // configurable fields
    public float rotationSpeed;
    
	void FixedUpdate ()
	{
        // whole circle gameobject rotates in z-axis in everu frame
		transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
