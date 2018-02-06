using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }

			// Counts the number of fingers of the user that are touching the screen
			int fingerCount = 0;
			foreach (Touch touch in Input.touches) {
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					fingerCount++;
			}
			if (fingerCount > 0)
				print("User has " + fingerCount + " finger(s) touching the screen");
        }


        private void FixedUpdate()
        {
            // Read keyboard keys as inputs
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");

			// For using acceleration in x axis as an input to move.
			Vector3 acceleration = Input.acceleration;
			float h = acceleration.x;

            // Pass all parameters to the character control script.
            m_Character.Move(h, m_Jump);
            m_Jump = false;
        }
    }
}
