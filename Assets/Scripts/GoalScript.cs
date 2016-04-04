using UnityEngine;
using System.Collections;


public class GoalScript : MonoBehaviour {

	[SerializeField]
	int attackingPlayer; // who scores in this goal
	[SerializeField]
	GameManagerScript gameMan; // reference to the GM script
	[SerializeField]
	ParticleSystem partSys;

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.transform.name == "Ball")
		{
			gameMan.GoalScored(attackingPlayer);
			partSys.transform.position = new Vector2(partSys.transform.position.x, other.transform.position.y);
			partSys.Play();
		}
	}
}
