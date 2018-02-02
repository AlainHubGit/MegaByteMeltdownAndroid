using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyByBoundary : MonoBehaviour 
{
	private GameObject boss;
	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		boss = GameObject.FindGameObjectWithTag ("Boss").gameObject;
	}

	public GameObject playerExplosion;


	/*void OnTriggerEnter(Collider other)
	{
		// Destroy everything that leaves the trigger
		Destroy(GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");

		Object.DestroyObject (GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");
	}	
	void OnTriggerEnter2D(Collider2D other)
	// void OnTriggerEnter2D(Collider2D other)
	{
		// Destroy everything that leaves the trigger

		Destroy(GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");

		Object.DestroyObject (GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");
	}	
*/

	void OnTriggerEnter2D(Collider2D other)
	// void OnTriggerEnter2D(Collider2D other)
	{
		// Destroy everything that leaves the trigger


		Destroy(GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");

		Destroy(GameObject.FindGameObjectWithTag ("Boss").gameObject);
		Debug.Log ("Boss Defeated!!!!!");

		if (GameObject.FindGameObjectWithTag ("Boss").gameObject) {
			// "other" in this case is the player
			Instantiate (playerExplosion, boss.transform.position, boss.transform.rotation);
			Debug.Log ("BOSS Explosion!!!!!");
			/*
		Object.DestroyObject (GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");
		*/
		}

	/*
	void OnTriggerExit(Collider other)
	{
		// Destroy everything that leaves the trigger
		Destroy(GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");

		Object.DestroyObject (GameObject.FindGameObjectWithTag ("Enemy").gameObject);
		Debug.Log ("ENEMMIGO ELIMINADO!!!!!");
	}	
		
	*/
}
}