using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;

	void Start()
	{
		/*
		* Next line will find the game object that holds our GameController.cs script. This reference will be called gameControllerObject. 
		* This will find the first game object in the scene that we have tagged as GameController
		*/
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		/* Next line is to see if we have successfully found the game controller object, and we check this by testing the reference
		 * to the Game Controller object. If it is not NULL (no reference)...
		*/
		if(gameControllerObject != null)
		{
			/*
			 * ... then we will set our Game Controller reference to the Game Controller component on the Game Controller object.
			 * We do this by searching the Game Controller object and getting the component on it, with GetComponent searching 
			 * for the type of GameController.
			*/
			Debug.Log ("GameController Found!!!!!");
			gameController = gameControllerObject.GetComponent<GameController> ();
		}
		/* We are going to write an "insurance policy". If after all this work, our Game Controller reference is 
		 * the same as NULL, we will use Debug.Log to put "Cannot find 'GameController' script" into the console. */
		if (gameController == null) 
		{
			Debug.Log ("Cannot find 'GameController' script");
		}

	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Boundary") 
		{
			return;
		}

		/* if (other.tag == "Ground") 
		{
			return;

		} */

		// Instantiate (explosion, transform.position, transform.rotation);

		/*
		if (other.tag == "Player") {
			// "other" in this case is the player
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);

			/* gameController is the variable holding the reference to our game controller instance 
			 * and with the dot called the GameOver function on gameController 
			// gameController.GameOver();
		}
	*/
		Debug.Log ("Collider OK!!!!!");

		// Send Score to GameController.cs Add score 
	    gameController.AddScore(scoreValue);
		Debug.Log ("AssScore Supposedly reached !!!!!");

		// Destroy(other.gameObject);
		// Destroy (gameObject);

	}
}
