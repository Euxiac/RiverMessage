using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{
	public class PlayerControllerJump3D : PlayerController
	{
		private Rigidbody _rb;

		// Use this for initialization
		void Start () 
		{
			_rb = GetComponent<Rigidbody>();
	
		}

		protected override void ProcessMovement()
		{
			if (_input != null)
			{
				
				CheckGround();
				
				base.ProcessMovement();
				if (_onGround && _input.buttonJump)
				{
					Jump();
				}
			}
		}

		protected void Jump()
		{
			_rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}
}
