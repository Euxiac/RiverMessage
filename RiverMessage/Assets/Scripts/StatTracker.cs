using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatTracker : MonoBehaviour {
	private float _food = 10f;
	private float _air = 10f;

	public Text Foodtracker;
	public Text Airtracker;
	private UserControl _controller;

	public float maxfood;
	public float maxair;
	public float decay;

	// Use this for initialization
	void Awake ()
	{
		_controller = GetComponent<UserControl>();
	}

	void Start () {
		_food = maxfood;
		_air = maxair;
	}
	
	// Update is called once per frame
	void Update () {
 
		if (_food >= 0)
		{
		_food = _food - decay * Time.deltaTime;
		}

		if (_controller.underwater && _air >= 0)
		{
			_air = _air - decay * Time.deltaTime;
		}
		else if (!_controller.underwater && _air <= maxair)
		{
			_air = _air + decay* 2 * Time.deltaTime;
		}

		UpdateScore();

	}

	void UpdateScore()
	{
		Foodtracker.text = "Food: " + (int)_food;
		Airtracker.text = "Air: " +  (int)_air;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Edible"))
		{
			//Fish fish = other.GameObject.GetComponent<Fish>();
			Debug.Log ("hi");
			Fish _fish = other.gameObject.GetComponent<Fish>();
			_food = _food + _fish.foodValue;
			if (_food > maxfood)
			{
				_food = maxfood;
			}
			Destroy(other.gameObject);
		}
		
	}
}
