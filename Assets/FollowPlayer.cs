using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // configurable fields
    public Transform player;
	
	void LateUpdate ()
	{
	    if (player.position.y > transform.position.y)
	    {
            transform.position = new Vector3(player.position.x, player.position.y, player.position.z-10f);
	    }
	}
}
