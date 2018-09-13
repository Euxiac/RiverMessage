using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{
	public class SimpleThirdPersonController : MonoBehaviour 
	{
		public float moveSpeed = 3.0f;
		//moves at moveSpeed units per second
		public float turnSpeed = 180.0f;
		//moves at turnspeed degrees per second

		// Use this for initialization
		void Start () 
		{
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			float v = Input.GetAxis("Vertical");
			float h = Input.GetAxis("Horizontal");
			
			//Movement
			transform.position += transform.forward * v * Time.deltaTime * moveSpeed;
			//how much time passe bertween frames is a property that returns a value
			//Rotation Version 1
			//transform.position(Vector3.up *h * Time.deltaTime *turnSpeed);

			//dont want to link movement to framerate 
			//World relative
			//Rotation Version 2
			//transform.Rotate(Vector3.up *h * Time.deltaTime *turnSpeed)); //Transform relative 
			
		}

	}
}