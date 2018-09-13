using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{
	public class PlayerControllerJump2D : PlayerController
	{
		private Rigidbody2D _rb;
		// Use this for initialization
		void Start () 
		{
			_rb = GetComponent<Rigidbody2D>();
		}

		protected override void ProcessMovement()
		{
			if (_input != null)
			{
				CheckGround();
				//base.ProcessMovement();
				transform.position += transform.right * moveSpeed * _input.movement.x * Time.deltaTime;
				
				if (_onGround && _input.buttonJump)
				{
					Jump();
				}
			}
		}


		protected void Jump()
		{
			_rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
		}

		protected override void CheckGround()
		{
			_onGround = false;
			if (groundCheckOrigin != null)
			{
				RaycastHit2D hit = Physics2D.Raycast((Vector2)groundCheckOrigin.position, -(Vector2)transform.up, groundDist);
				if (hit != null && hit.collider != null)
				{
					Debug.Log(hit.collider.name);
					_onGround = true;
				}

			}
		}
	}
}
