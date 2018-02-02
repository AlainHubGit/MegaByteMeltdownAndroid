using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossFight : MonoBehaviour {


	public GameObject playerExplosion;
	public float speed;
	private Transform target;
	private Transform boss;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		//boss = GameObject.FindGameObjectWithTag ("Boss").GetComponent<Transform> ();
	}



	void OnCollisionEnter2D(Collision2D other)
	{
		

		if(other.collider.tag == "Player")
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		}



	}




	// Update is called once per frame
	void Update () {
		 transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);

	}



}
