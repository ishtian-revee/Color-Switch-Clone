using UnityEngine;

public class Portal : MonoBehaviour {

    // configurable fields
    public SpriteRenderer player;
    public SpriteRenderer portal;
    public Color[] colors;

    // private fields
    private string color;

	// Use this for initialization
	void Start ()
	{
		InitPortalColor();
	}

    // this method will initialize the current portal color randomly
    private void InitPortalColor()
    {
        // getting a random number from 0 to 3 for 4 different colors
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                portal.color = colors[index];
                color = "Cyan";
                break;
            case 1:
                portal.color = colors[index];
                color = "Yellow";
                break;
            case 2:
                portal.color = colors[index];
                color = "Pink";
                break;
            case 3:
                portal.color = colors[index];
                color = "Magenta";
                break;
        }
    }

    // this method will check if any collision happens
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.color = portal.color;
            Destroy(this.gameObject);
        }
    }
}
