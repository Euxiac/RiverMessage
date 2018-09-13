using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{
	public class SimpleThirdPersonControllerWithJump : MonoBehaviour 
	{
		public float moveSpeed = 3.0f;
		public float turnSpeed = 180.0f;
		public float jumpPower = 10.0f;

		//Jump Forever?
		public float groundDist = 100.9f;

		private Rigidbody _rb;

		//Jump Forever?
		private bool onGround;

		// Use this for initialization
		void Start () 
		{
			_rb = GetComponent<Rigidbody>();
		}
		
		// Update is called once per frame
		void Update () 
		{
			float v = Input.GetAxis("Vertical");
			float h = Input.GetAxis("Horizontal");
			
			transform.position += transform.forward * moveSpeed * v * Time.deltaTime;
			//V1
			//transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime); 
			//V2
			transform.Rotate(transform.up * h * turnSpeed * Time.deltaTime); 
			
			if (Input.GetButtonDown("Jump"))
			{
				//We need to do some checking
				//to see if we can jump.
				CheckGround();
				if (onGround == true)
				{
				Jump();
				}
			}
		}


		void CheckGround()
		{
			RaycastHit hit;

			// 3D Raycast returns bool, and (one form) takes:
			// Origin
			// Direction
			// RaycastHit (output variable)
			// Distance to raycast.
			
			if (Physics.Raycast(transform.position, Vector3.down , out hit, groundDist) )
			{
				Debug.Log(hit.collider);
				onGround = true;
			}
			else
			{
				onGround = false;
			}
		}

		void Jump()
		{
			if (_rb != null)
			{
				_rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
			}
		}

	}

}