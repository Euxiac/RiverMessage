using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD210.Tutorial6
{

	[System.Serializable]
	public class InputState
	{
		//Default values
		public string hAxis = "Horizontal";
		public string vAxis = "Vertical";
		public string actionButton = "Fire1";
		public string jumpButton = "Jump";
		public string mouseX = "Mouse X";
		public string mouseY = "Mouse Y";

		public Vector2 movement;
		public Vector2 mouse;
		public bool buttonAction = false;
		public bool buttonJump = false;
	
	}
	public class PlayerInput : MonoBehaviour 
	{
		
		public InputState state; //we will collect input into this object
		PlayerController _controller; //we will feed the controller the input.
		
		// Use this for initialization
		void Start () 
		{
			state = new InputState();
			//Get the controller component attached to this gameobject
			_controller = GetComponent<PlayerController>();
		}
		
		// Update is called once per frame
		void Update () 
		{
			float h = Input.GetAxis(state.hAxis);
			float v = Input.GetAxis(state.vAxis);
			float mx = Input.GetAxis(state.mouseX);
			float my = Input.GetAxis(state.mouseY);
			
			state.buttonAction = Input.GetButtonDown(state.actionButton);
			state.buttonJump = Input.GetButtonDown(state.jumpButton);
			state.movement = new Vector2(h, v);
			state.mouse = new Vector2(mx, my);

			_controller.SetInput(state); //give the input state to the controller.
		}
	}
}
