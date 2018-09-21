using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFollower : MonoBehaviour {
	public GameObject player;
	//private Vector3 _currentPos;
	//private Transform _playerPos;
	//private UserControl _controller;
	// Use this for initialization
	private Vector3 _offset;
	void Start ()
	{
		_offset = transform.position - player.transform.position;
		Debug.Log ("offset: " + _offset);
	}

	// Update is called once per frame
	void LateUpdate () {
		//_playerPos = player.Transform;
		transform.position = player.transform.position + _offset;
	}
}
