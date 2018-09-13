using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{
	public class PlayerController : MonoBehaviour 
	{
		public float moveSpeed = 3.0f;
		public float turnSpeed = 360.0f;
		public Transform groundCheckOrigin;
		public float groundDist = 0.1f;
		public float jumpForce = 5.0f;

		protected bool _onGround;
		protected InputState _input;

		// Use this for initialization
		void Start () 
		{
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			ProcessMovement();
		}

		public void SetInput(InputState state)
		{
			_input = state;
		}

		protected virtual void ProcessMovement()
		{
			if (_input != null)
			{
				transform.position += transform.forward * moveSpeed * _input.movement.y * Time.deltaTime;
				transform.Rotate(transform.up * turnSpeed * _input.movement.x * Time.deltaTime);
			}
		}

		protected virtual void CheckGround()
		{
			_onGround = false;
			if (groundCheckOrigin != null)
			{
				RaycastHit hit;
				_onGround = Physics.Raycast(groundCheckOrigin.position, -transform.up, out hit, groundDist);
			}
		}
	}
}
