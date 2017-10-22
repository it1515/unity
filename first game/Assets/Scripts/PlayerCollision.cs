using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "Obstacle"){
			FindObjectOfType<Health>().health--;
		}
		if(collisionInfo.collider.tag == "Obstacle" && FindObjectOfType<Health>().health == 0){
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
