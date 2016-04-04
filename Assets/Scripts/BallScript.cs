using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	[SerializeField]
	float forceValue = 4.5f;
	Rigidbody2D Body;

    //initialization

	void Start () {
		Body = GetComponent<Rigidbody2D>();
	}
	
	public void Reset()
	{
		// reset the ball position // ball movement
		Body.velocity = Vector2.zero;
		transform.position = new Vector2(0,0);
		Body.AddForce (new Vector2 (forceValue * 50, 50));
		forceValue = forceValue * -1;
	}

	public void Stop()
	{
		// stop the ball
		Body.velocity = Vector2.zero;
	}
}
