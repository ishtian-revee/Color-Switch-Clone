using UnityEngine;

public class Player : MonoBehaviour {

    // configurable fields
    public float jumpForce;
    public Rigidbody2D rigidBody;
    public SpriteRenderer spriteRenderer;
    public Color[] colors;

    // private fields
    private bool isSpacePressed, isMousePressed;

    void Start()
    {
        InitPlayerColor();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isSpacePressed = true;
        }
        else
        {
            isSpacePressed = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;
        }
        else
        {
            isMousePressed = false;
        }
    }

	void FixedUpdate ()
	{
	    if (isSpacePressed || isMousePressed)
	    {
            rigidBody.velocity = Vector2.up * jumpForce;
	    }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    // this method will initialize the payer color
    private void InitPlayerColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                spriteRenderer.color = colors[index];
                break;
            case 1:
                spriteRenderer.color = colors[index];
                break;
            case 2:
                spriteRenderer.color = colors[index];
                break;
            case 3:
                spriteRenderer.color = colors[index];
                break;
        }
    }
}
