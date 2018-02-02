using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

	public float scrollSpeed;

	// Length of tile along Z axis
	public float tileSizeZ;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		/* As time advances on the game, it will increase the float number of where we want to be. 
		 * The tile size is the total size of the background tile from botom to top */

		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSizeZ);

		// First set the position, but gradually we want the background to be scrolling in the Z axis (Vector3.forward) * new position advancing with time
		transform.position = startPosition + Vector3.right * newPosition;
	}
}
