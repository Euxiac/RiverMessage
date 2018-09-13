using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{
	public class SimpleFirstPersonControllerWithJump : MonoBehaviour 
	{
		public float moveSpeed = 3.0f;
		public float turnSpeed = 180.0f;
		public float jumpPower = 10.0f;

		//Jump Forever?
		public float groundDist = 100.9f;

		private Rigidbody _rb;
		public Camera camera;

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
				
				CheckGround(); //Jump Forever?
				if (onGround) //Jump Forever?
					Jump();
			}
		}

		//Jump Forever?
		void CheckGround()
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, -transform.up, out hit, groundDist) )
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
			_rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
		}

	}
}
