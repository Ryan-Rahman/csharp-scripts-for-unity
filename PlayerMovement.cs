//top down simple 2d player movement script
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
  //identifying variables
	public float moveSpeed = 5f;
	public Rigidbody2D rb;
	
  Vector2 movement;

	void update() {
		//input
    //works with WASD and arrow keys
		movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
	}
	
	void FixedUpdate() {
		//movement
		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime)
	}

}
