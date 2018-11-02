using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // configurable fields
    public Transform player;
	
	void LateUpdate ()
	{
	    if (player.position.y > transform.position.y)
	    {
            // camera position will set as fixed at player x, y axis when player reaches to mid level height of the view
            transform.position = new Vector3(player.position.x, player.position.y, player.position.z-10f);
	    }
	}
}
