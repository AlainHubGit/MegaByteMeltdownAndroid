using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class SimpleTouchPadJump : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	// Global Variables
	private bool touched;
	private int pointerID;
	private bool canJump;

	void Awake(){
		touched = false;
	}

	public void OnPointerDown (PointerEventData data) {
		if(!touched){
			touched = true;
			pointerID = data.pointerId;
			canJump = true;
		}
	}

	public void OnPointerUp (PointerEventData data) {
		// Reset Everything
		if(data.pointerId == pointerID){
			canJump = false;
			touched = false;
		}
	}

	public bool CanJump(){
		return canJump;
	}

}
