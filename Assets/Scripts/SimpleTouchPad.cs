using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class SimpleTouchPad : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler {

	// Global Variables
	public float smoothing;

	private Vector2 origin;
	private Vector2 direction;
	private Vector2 smoothDirection;
	private bool touched;
	private int pointerID;


	void Awake(){
		direction = Vector2.zero;
		touched = false;
	}

	public void OnPointerDown (PointerEventData data) {
		if(!touched){
			touched = true;
			pointerID = data.pointerId;
		// Set our start point
		origin = data.position;
	}
	}

	public void OnDrag (PointerEventData data) {
		if(data.pointerId == pointerID){
		// Compare the difference between our start point and current pointer position
		Vector2 currentPosition = data.position;
		Vector2 directionRaw = currentPosition - origin;
		// Do not rename it Vector2 direction, it will make direction a local variable, but we need a global variable.
		direction = directionRaw.normalized;
		Debug.Log ("direction in OnDrag (PointerEventData data) is:" + direction);
	}
	}

	public void OnPointerUp (PointerEventData data) {
	// Reset Everything
		if(data.pointerId == pointerID){
		direction = Vector2.zero;
			touched = false;
	}
	}

	public Vector2 GetDirection(){
		smoothDirection = Vector2.MoveTowards (smoothDirection, direction, smoothing);
		Debug.Log ("smoothDirection in Vector2 GetDirection() is:" + smoothDirection);
		// return direction;
		return smoothDirection;
	}

}
