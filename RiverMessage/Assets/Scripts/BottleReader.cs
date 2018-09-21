using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BottleReader : MonoBehaviour {
	public GameObject Message1;
	//private bool touchingbottle;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Message1.SetActive(true);
	}

	void OnTriggerExit(Collider other)
	{
		Message1.SetActive(false);
	}
}
