using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {
	
	[SerializeField]
	bool isPlayerTwo;
	[SerializeField]
	float speed = 0.2f;       // This represents how far paddel moves per frame
	Transform myTransform;    // object's transform reference
	int direction = 0; // 1 == up  -1 == down
	float previousPositionY;

	// Initialization
	void Start () {
		myTransform = transform;
		previousPositionY = myTransform.position.y;
	}
	
	// FixedUpdate envoked 1nc per physics frame

	void FixedUpdate () {
		// need to determine which player
		if (isPlayerTwo)
		{
			if (Input.GetKey ("o"))
				MoveUp ();
			else if (Input.GetKey ("l"))
				MoveDown ();
		}
		else // else is player 1
		{
			if (Input.GetKey ("w"))
				MoveUp ();
			else if (Input.GetKey ("s"))
				MoveDown ();
		}

		if (previousPositionY > myTransform.position.y)
			direction = -1;
		else if (previousPositionY < myTransform.position.y)
			direction =1;
		else
			direction = 0;
	}
	
	// move the player's paddle up or down by an amount determined by speed
    //----------------------------------------------------------------------------------------------------------
	void MoveUp()
	{
		myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y + speed);
	}
	
	
	void MoveDown()
	{
		myTransform.position = new Vector2 (myTransform.position.x, myTransform.position.y - speed);            
	}

    //----------------------------------------------------------------------------------------------------------
    void LateUpdate()
	{
		previousPositionY = myTransform.position.y;
	}

	void OnCollisionExit2D(Collision2D other)
	{
		float adjust = 5 * direction;
		other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x, other.rigidbody.velocity.y + adjust);        
	}

}