using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour {

    // configurable fields
    public float jumpForce;
    public Rigidbody2D rigidBody;
    public SpriteRenderer spriteRenderer;
    public Color[] colors;

    // private fields
    private bool isSpacePressed, isMousePressed;
    private bool touchedPortal;
    private String currentColor;

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
        if (other.tag != "ColorPortal")
        {
            if (other.tag != currentColor)
            {
                // loads the same scene again if the player collide with wrong color object 
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                touchedPortal = false;
            }
        }
    }

    // this method will initialize the payer color
    private void InitPlayerColor()
    {
        // getting a random number from 0 to 3 for 4 different colors
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                spriteRenderer.color = colors[index];
                currentColor = "Cyan";
                break;
            case 1:
                spriteRenderer.color = colors[index];
                currentColor = "Yellow";
                break;
            case 2:
                spriteRenderer.color = colors[index];
                currentColor = "Pink";
                break;
            case 3:
                spriteRenderer.color = colors[index];
                currentColor = "Magenta";
                break;
        }
    }
}
