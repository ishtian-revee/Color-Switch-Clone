using UnityEngine;

public class Portal : MonoBehaviour {

    // configurable fields
    public SpriteRenderer player;
    public SpriteRenderer portal;
    public Color[] colors;

    // private fields

	// Use this for initialization
	void Start ()
	{
		InitPortalColor();
	}

    // this method will initialize the current portal color randomly
    private void InitPortalColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                portal.color = colors[index];
                break;
            case 1:
                portal.color = colors[index];
                break;
            case 2:
                portal.color = colors[index];
                break;
            case 3:
                portal.color = colors[index];
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.color = portal.color;
            Destroy(this.gameObject);
        }
    }
}
