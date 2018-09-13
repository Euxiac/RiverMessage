using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {
	public string hAxis = "Horizontal";
	public string vAxis = "Vertical";
	public string dAxis = "Depth";

	public float moveSpeed = 3.0f;
	public float turnSpeed = 180.0f;
	public float divePower = 3.0f;

	private float Depth;
	// Use this for initialization
	void Start () {
		Depth = transform.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		float d = Input.GetAxis("Depth");
			
			transform.position += transform.forward * moveSpeed * v * Time.deltaTime;
			transform.Rotate(transform.up * h * turnSpeed * Time.deltaTime); 
			transform.position += transform.up * divePower * d * Time.deltaTime;
			
			//transform.Rotate(Vector3.right * Time.deltaTime);
			//transform.Rotate(transform.right * d * Time.deltaTime);
	}
}
