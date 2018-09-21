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
	public float waterline = 2.4f;
	public Vector3 playerPos;

	public bool underwater =  false;

	private float Depth;
	// Use this for initialization
	void Start () {
		Depth = transform.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		Depth = transform.localPosition.y;
			if (Depth <= waterline)
		{
			underwater = true;
		}
		else if (Depth > waterline)
		{
			underwater = false;
		}


		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		float d = Input.GetAxis("Depth");
			
			transform.position += transform.forward * moveSpeed * v * Time.deltaTime;
			transform.Rotate(transform.up * h * turnSpeed * Time.deltaTime); 
			transform.position += transform.up * divePower * d * Time.deltaTime;
		
		playerPos = new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
		//Debug.Log ("Depth: " + underwater + Depth);
			//transform.Rotate(Vector3.right * Time.deltaTime);
			//transform.Rotate(transform.right * d * Time.deltaTime);
	}
}
