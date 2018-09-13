using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpLogic : MonoBehaviour 
{
	public int max_jumps = 1;
	private int _remaining_jumps;
	// Use this for initialization
	void Start () 
	{
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Reset()
	{
		_remaining_jumps = max_jumps;
	}

	public void UpgradeJump()
	{
		max_jumps += 1;
	}

	public int UseJump()
	{
		_remaining_jumps -=1;
		return _remaining_jumps;
	}

	public bool CanJump()
	{
		return _remaining_jumps > 0;
	}

}
