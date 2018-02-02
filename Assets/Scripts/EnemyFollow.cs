using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float speed;
	private Transform target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.collider.tag == "Firewall")
		{
			print("destroyed enemy");
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		//transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);

	}



}
